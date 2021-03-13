!+============================================================================+
!| Company:   SOFiSTiK AG                                                     |
!| Version:   SOFiSTIK 2018                                                   |
!+============================================================================+
	
! ToDo (troubleshooting)
! ======================
! 1. Project Properties -> Fortran -> General -> Additional Include Directories and add 
!    "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018\interfaces\examples\fortran"
! 2. Copy all DLLs from "ANALYSIS_50_X64\interfaces\64bit_debug" to "...single_span_girder\single_span_girder\x64\Debug"
! 3. Copy the icudt57.dll, icuin57.dll and icuuc57.dll from "ANALYSIS_50_X64" to "...single_span_girder\x64\Debug" 
! 4. Project Properties -> Linker -> Input -> Additional Dependencies and add
!     "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018\interfaces\64bit_debug\cdb_w50_x64d.lib"
! 5. Add the *.for headers from "ANALYSIS_50_X64\interfaces\examples\fortran" 
!   into the Visual Studio Solution: Header Files -> Add Existing Item"
! 6. Add "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018" to environment PATH variable (not required, but recommended)

	program single_span_girder
	use cdbase
	use CDB_TYPES           ! this are our included data types
	use CDB_TYPES_CON       ! add the types into project / solution
	use CDB_TYPES_GEO
	use CDB_TYPES_LFC
	use CDB_TYPES_MAT
	use CDB_TYPES_LFC
	use CDB_TYPES_TEN
	use CDB_TYPES_SYS
	use CDB_TYPES_SCT
	implicit none
		
	! Define the variable
	integer :: nid, l, ie, index
	character(len=30)   :: file
	character(len=72)   :: text
	type(CNODE) :: typ_cnode                ! key 20/00     Nodes
	type(CSECT_REC) :: typ_csect_rec        ! key 9/NR:10   SectiontypeRectangular T-Beam
	type(CMAT_CONC) :: typ_cmat_conc        ! key 1/NR:1    MaterialConcrete
	type(CMAT_STEE) :: typ_cmat_stee        ! key 1/NR:1    MaterialSteel
	type(CBEAM_FOC) :: typ_cbeam_foc        ! key 102/LC:0  Maximum of Total Beam forces and deformations 
	integer :: datalen, pos
	integer :: kwh, kwl, ret
	
	! Variables used to store the values from CDB
	real :: fy
	real :: fck
	real :: Med
	real :: Ned
	real :: b
	real :: h
	real :: su
	real :: so
	
	! Variables used for the iteration
	real :: fcd
	real :: fyd
	real :: epss
	real :: epsc
	real :: Mrd
	real :: mu
	real :: alpha
	real :: xi
	real :: d
	real :: ka
	real :: z
	real :: zeta
	real :: omega
	real :: As1
	real :: Meds
	real :: x
	
	! Define the parameters for cdinti()
	! nid = 99,     test if NAME is a valid database and open the base if possible. Return with the assigned index.
	!               If the file does not exist, it will be created.
	
	nid=99
	file = "simple_span_girder.cdb"   !name of the cdb or the full path
	
	! Connect to the CDB
	call cdinit(file,nid)
	if (nid > 0) then
		write(*,*) "  cdb_init of ", file," successful ", nid
	else   
		write(*,*) "  cdb_init of ", file," not successful ", nid
	endif 
	
	
	!====================!
	! READ THE FCK VALUE !
	!====================!
	index = nid
	kwh = 1
	kwl = 1
	datalen = sizeof(typ_cmat_conc)
	pos = 1
	ie = 0
	do while (ie < 2)   ! Read data while ie == 0, Returnvalue: 
						! (0) no error, 
						! (1) Item is longer than Data, 
						! (2) End of file reached
						! (3) key does not exist        
		call cdget(index, kwh, kwl, typ_cmat_conc, datalen, pos, ie) 
		if (typ_cmat_conc%id == 1.0) then 
			fck = typ_cmat_conc%fck
		end if
		
		datalen = sizeof(typ_cmat_conc)
	end do
	
	call cdflush(index)
	
	!===================!
	! READ THE FY VALUE !
	!===================!
	index = nid
	kwh = 1
	kwl = 2
	datalen = sizeof(typ_cmat_stee)
	pos = 1
	ie = 0
	do while (ie < 2)       
		call cdget(index, kwh, kwl, typ_cmat_stee, datalen, pos, ie) 
		if (typ_cmat_stee%id == 1.0) then 
			fy = typ_cmat_stee%fy
		end if
		
		datalen = sizeof(typ_cmat_stee)
	end do
	
	!=========================!
	! READ THE Med, NEd VALUE !
	!=========================!
	index = nid
	kwh = 102
	kwl = 1001
	datalen = sizeof(typ_cbeam_foc)
	pos = 1
	ie = 0
	
	Ned = 0
	Med = 0
	do while (ie == 0)       
		call cdget(index, kwh, kwl, typ_cbeam_foc, datalen, pos, ie) 
		if (typ_cbeam_foc%id == 0) then 
			if ((abs(Ned) < abs(typ_cbeam_foc%n)) .and. (abs(typ_cbeam_foc%n) < 1E+30)) then
				Ned = typ_cbeam_foc%n
			end if
			if ((abs(Med) < abs(typ_cbeam_foc%my)) .and. (abs(typ_cbeam_foc%my) < 1E+30)) then
				Med = typ_cbeam_foc%my
			end if
		end if
		
		datalen = sizeof(typ_cbeam_foc)
	end do
	
	call cdflush(index)
	
	!=========================!
	! READ THE h, b, SU VALUE !
	!=========================!
	index = nid
	kwh = 9
	kwl = 1
	datalen = sizeof(typ_csect_rec)
	pos = 1
	ie = 0
	
	do while (ie == 0)       
		call cdget(index, kwh, kwl, typ_csect_rec, datalen, pos, ie) 
		if (typ_csect_rec%id == 10) then    ! typ_csect_rec%id = 10 for rectangular cross-section
			b = typ_csect_rec%b
			h = typ_csect_rec%h
			so = typ_csect_rec%so
			su = typ_csect_rec%su
		end if
		
		datalen = sizeof(typ_csect_rec)
	end do  
	
	!===========!
	! ITERATION !
	!===========!
	
	fcd = fck / 1.5 * 0.85
	fyd = fy / 1.15
	epss = 25.0
	epsc = 0.0
	Mrd = 0.0
	mu = 0.0
	alpha = 0.0
	xi = 0.0
	x = 0
	d = h - su
	ka = 0.0
	z = 0.0
	zeta = 0.0
	omega = 0.0
	As1 = 0.0
	Meds = Med - Ned*(h/2 - su)
	
	do while (Mrd <= Meds .and. mu < 0.296)
		if ((epsc > 0) .and. (epsc <= 2)) then
			alpha = epsc/12*(6 - epsc)
		elseif (epsc > 2 .and. epsc <= 3.5) then
			alpha = (3 * epsc - 2) / (3 * epsc)
		end if
		
		! Calculate the Xi value
		xi = epsc / (epss + epsc)
		
		! Calculate x
		x = xi * d
		
		! Calculate ka
		if ((epsc > 0) .and. (epsc <= 2)) then
			ka = (8 - epsc) / (4 * (6 - epsc))
		elseif ((epsc > 2) .and. (epsc <= 3.5)) then
			ka = (epsc * (3 * epsc - 4) + 2) / (2 * epsc * (3 * epsc - 2))
		end if
		
		! Calculate z
		z = d - ka * x
		
		! Calculate zeta
		zeta = 1 - ka * xi
		
		! Calculate omega
		omega = alpha * xi
		
		! Calculate mu
		mu = alpha * xi * zeta
		
		! Calculate the Mrd resistance moment
		Mrd = alpha * xi * d * b * fcd * zeta * d
		
		! Required reinforcement
		As1 = (1 / fyd) * (omega * b * d * fcd + Ned)
		
		if (epsc == 3.5) then
			epss = 25
			
			do while ((Mrd <= Meds) .and. (epss >= 0.0) .and. (mu < 0.371)) 
				if ((epsc > 0.0) .and. (epsc <= 2.0)) then
					alpha = epsc / 12 * (6 - epsc)
				elseif (epsc > 2.0 .and. epsc <= 3.5) then
					alpha = (3 * epsc - 2) / (3 * epsc)
				end if
				
				! Calculate the Xi value
				xi = epsc / (epss + epsc)
				
				! Calculate x
				x = xi * d
				
				! Calculate ka
				if (epsc > 0 .and. epsc <= 2.0) then
					ka = ((8 - epsc) / (4 * (6 - epsc)))
				elseif (epsc > 2 .and. epsc <= 3.5) then
					ka = (epsc * (3 * epsc - 4) + 2) / (2 * epsc * (3 * epsc - 2))
				end if
				
				! Calculate z
				z = d - ka * x
				
				! Calculate zeta
				zeta = 1 - ka * xi
				
				! Calculate omega
				omega = alpha * xi
				
				! Calculate mu
				mu = alpha * xi * zeta
				
				! Calculate the Mrd resistance
				Mrd = alpha * xi * d * b * fcd * zeta * d
				
				! Required reinforcement
				As1 = (1 / fyd) * (omega * b * d * fcd + Ned)
				
				if (epss == 0.0) then
					print *, "Reinforcement reached 0 [o/oo]"
				end if
				
				epss = epss - 0.001
			end do    
		end if
		
		! Change the epsc value
		epsc = epsc + 0.001
	end do
	
	! Close the CDB
	call cdclose(0)
	
	print *, "Ned =", Ned
	print *, "Med =", Med
	print *, "Meds =", Meds
	print *, "------------"
	print *, "fcd [MPa] =", fcd / 1000
	print *, "fyd [MPa] =", fyd / 1000
	print *, "epsc [o/oo] =", epsc
	print *, "epss [o/oo] =", epss
	print *, "alpha [-] =", alpha
	print *, "ka [-] =", ka
	print *, "z [m] =", z
	print *, "zeta [-]", zeta
	print *, "omega [-] =", omega
	print *, "mu [-] =", mu
	print *, "d [cm] =", d * 100
	print *, "Xi [-] =", Xi
	print *, "x [cm] =", x * 100
	print *, "Mrd [kNm] =", Mrd
	print *, "------------"
	print *, "As1 [cm2] =", As1 * 100**2
	
	! Get the status and print it (if .cdb is closed status = 0)
	call cdstat(nid, ret)
	print *, "Status:", ret
	
	! The console will close if we press <ENTER> key
	print *, "Press <ENTER> key to close the program"
	read (*,*)
	end program single_span_girder
	
!****************************************************************************