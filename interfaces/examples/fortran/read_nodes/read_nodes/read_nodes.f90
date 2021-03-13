!+============================================================================+
!| Company:   SOFiSTiK AG                                                     |
!| Version:   SOFiSTIK 2018                                                   |
!+============================================================================+
	
! ToDo (troubleshooting)
! ======================
! 1. Project Properties -> Fortran -> General -> Additional Include Directories and add 
!    "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018\interfaces\examples\fortran"
! 2. Copy all DLLs from "ANALYSIS_50_X64\interfaces\64bit_debug" to "...read_nodes\read_nodes\x64\Debug"
! 3. Copy the icudt57.dll, icuin57.dll and icuuc57.dll from "ANALYSIS_50_X64" to "...read_nodes\x64\Debug" 
! 4. Project Properties -> Linker -> Input -> Additional Dependencies and add
!     "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018\interfaces\64bit_debug\cdb_w50_x64d.lib"
! 5. Add "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018" to environment PATH variable (not required, but recommended)

	program read_nodes
	use cdbase
	implicit none
	
	! this is our data type for nodes
	type cnode                   ! 20/00  Nodes
		sequence
		integer   nr               !        node-number
		integer   inr              !        internal node-number
		integer   kfix             !        degree of freedoms
		integer   ncod             !        additional bit code
		real*4      xyz(3)         ! [1001] X-Y-Z-ordinates
	end type cnode
	
	! Define the variable
	integer :: nid, l, ie, index
	character(len=30)   :: file
	character(len=72)   :: text
	type(CNODE) :: dataval
	integer :: datalen, pos
	integer :: kwh, kwl, ret
	
	! Define the parameters for cdinti()
	! nid = 99,     test if NAME is a valid database and open the base if possible. Return with the assigned index.
	!               If the file does not exist, it will be created.
	
	nid=99
	file = "read_nodes.cdb"   !name of the cdb or the full path
	
	! Connect to the CDB
	call cdinit(file,nid)
	if (nid > 0) then
		write(*,*) "  cdb_init of ", file," successful ", nid
	else   
		write(*,*) "  cdb_init of ", file," not successful ", nid
	endif 
	
	! Lets read the nodes now
	index = nid    
	kwh = 20
	kwl = 0
	datalen = 28    ! for nodes we have datalen = 28
	pos = 1         ! set position to 1, see cdbase.chm
					! = 0 Position to first Item (REWIND)
					! > 0 Read next item from current read pointer read pointer will advance by one item.
	ie = 0          ! return value for the cdget
	
	! Read the nodes 
	do while (ie == 0)  ! Read data while ie == 0, Returnvalue: 
						! (0) no error, 
						! (1) Item is longer than Data, 
						! (2) End of file reached
						! (3) key does not exist
	
		call cdget(index, 20, 0, dataval, datalen, pos, ie) 
		print *, dataval
	end do
	
	! Close the CDB
	call cdclose(0)
	
	! Get the status and print it (if .cdb is closed status = 0)
	call cdstat(nid, ret)
	print *, "Status:", ret
	
	! The console will close if we press <ENTER> key
	print *, "Press <ENTER> key to close the program"
	read (*,*)
	end program read_nodes
	
!****************************************************************************