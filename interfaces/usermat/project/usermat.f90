!==================================================================================!
! HOWTO CREATE YOUR OWN USER-DEFINED MATERIAL MODEL
!==================================================================================!
! VERSION: 1.0 16.06.2006
! AUTHOR: SOFiSTiK AG, OBERSCHLEISSHEIM, Dr.-Ing. H. Heidkamp MSc
!
! 1) basic procedure:
!     the user-defined material model is dynamically loaded by the core programs
!     (TALPA/ ASE) at runtime. to accomplish this, the user-defined material model 
!     must be compiled and linked into a dynamic library, i.e. a
!     ".dll" file on Windows and a ".so" file on Linux.
!
!     the name of the user-defined module can be chosen arbitrarily. yet, the
!     environment variable "SOFISTIK_USERMATDLL" must be defined accordingly
!     (->see AQUA/TALPA/ASE manual, section NMAT).
!
! 2) interface routine:
!     the interface routine must be set up as described in the AQUA/TALPA/ASE manual,
!     section NMAT
!        - name of the routine: NMAT3D_USD
!        - parameter list as described
!
! 3) compiler/ linker settings:
!     To assure compatibility with the SOFiSTiK software framework, 
!       - always compile as multithread-DLL runtime-library!
!       - for linking and interface export, include a module definition file ".def" into 
!         your project, as provided by usermat.def
!   
!     Additionally, the following compiler and linker tools are mandatory:
!
!     SOFISTIK 2016 version on Windows (64 bit):
!       - Linker, C/C++ compiler                                  : Microsoft C/C++ Visual Studio 2012 + Servie Pack 3
!       - Fortran Compiler (only required for Fortran sources)    : Intel Fortran 15.0
!
!     SOFISTIK 2014 version on Windows (64 bit or 32bit):
!       - Linker, C/C++ compiler                                  : Microsoft C/C++ Visual Studio 2010 + Servie Pack 1
!       - Fortran Compiler (only required for Fortran sources)    : Intel Fortran 13.1
!
!     SOFISTIK 2014 version on Linux (64 bit):
!       - Linker, C/C++ compiler                                  : gcc 4.6.3
!       - Fortran Compiler (only required for Fortran sources)    : Intel Fortran 13.1
!
! 4) having compiled and linked your program, place a copy of the binary in the
!    corresponding SOFiSTiK installation directory. now you are ready to perform...
!
! 5) programming example is given below
!
!==================================================================================!


subroutine nmat3d_usd( Ss, SsPrim, deltaSn, SnIe, StateV, Mtype, ParMat, ElcMat, D,&
                        C, Ctrl, deltaTime, iNonl,iUpd, iErr, NrEl, iGP )
!==================================================================================!
!   exemplary FORTRAN interface routine of a user-defined material model           !
!                                                                                  !
!        infinitesimal (geometric linear) analysis                                 !
!        -> egineering strains, cauchy stresses                                    !
!==================================================================================!
!
! VERSION: 1.0 16.06.2006
! AUTHOR: SOFiSTiK AG, OBERSCHLEISSHEIM, Dr.-Ing. H. Heidkamp MSc
!
! NOTES: Computation of linear elastic response according to Hooke's law
!        based on provided Young's modulus ParMat(1) and Poisson's ratio ParMat(2)
!
!
! INPUT AS DOCUMENTED IN AQUA MANUAL, section NMAT
! -------------------------------------------------
! SsPrim(6) : primary stress state [xx,yy,zz,xy,xz,yz]
! deltaSn(6): strain increment related to primary stress state [xx,yy,zz,xy,xz,yz]
! SnIe(6)   : not used
! StateV(10): (nonlinear) state variables
! Mtype     : identifier for material type
!             101..108 for NMAT USP1..USP8
!             109..116 for NMAT USD1..USD8
! ParMat(12): nonlinear material parameters P1..P12
!             ( 1) here: Young's modulus
!             ( 2) here: Poisson's ratio
!             ( 3)
!             ( 4)
!             ( 5)
!             ( 6)
!             ( 7)
!             ( 8)
!             ( 9)
!             (10)
!             (11)
!             (12)
! ElcMat(16): elastic material constants according to CDB-record 001/NR
! D (6,6)   : elastic material constitutive (stiffness)
! C (6,6)   : elastic compliance
! Ctrl(5)   : control parameters from CTRL MSTE (TALPA/ASE) or CTRL - record (e.g. for iteration control,
!             debug-level etc.)
!     (1)   : ---
!     (2)   : ---
!     (3)   : ---
!     (4)   : ---
!     (5)   : ---
! deltaTime : time duration of load step
! NrEl      : element number
! iGP       : identifier of material point
!
! OUTPUT AS DOCUMENTED IN AQUA MANUAL, section NMAT
! -------------------------------------------------
! Ss(6)     : updated stress tensor [xx,yy,zz,xy,xz,yz]
! SnIe(6)   : not used
! StateV(10): updated state variables (can be visualized with WINGRAF)
!        (1): ---
!        (2): ---
!        (3): ---
!        (4): ---
!        (5): ---
!        (6): ---
!        (7): ---
!        (8): ---
!        (9): ---
!       (10): ---
! D (6,6)   : updated algorithmic tangential constitutive
! iNonl     : =0 response was linear elastic; =1 for nonlinear response
! iUpd      : =0 algorithmic tangential constitutive was not established
!             =1 algorithmic tangential constitutive was established (ASE, only)
! iErr      : SOFISTIK error level:
!             =  0 no error detected
!             =  1 error in material routine -> program will terminate
!             =-99 addressed user defined material model is not available
!
!==================================================================================!
   implicit none
   !
   ! declaration of dummy parameters
   !
   double precision, intent( out )     :: Ss(6)
   double precision, intent( in )      :: SsPrim(6), deltaSn(6)
   double precision, intent( inout )   :: SnIe(6), StateV(15), D(6,6)
   double precision, intent( in )      :: ParMat(18), ElcMat(16), C(6,6), deltaTime
   real, intent( in )                  :: Ctrl(5)
   integer, intent( in )               :: Mtype, NrEl, iGP
   integer, intent( out )              :: iNonl, iUpd, iErr
   !
   ! declaration of local parameters
   !


   ! model implemeted for MTYPE = 101 (corresponds to NMAT USP1...)
   !     parmat(1)= 1st NMAT parameter P1
   !     parmat(2)= 2nd NMAT parameter P2
   select case( Mtype )
   case( 101 )
      call get_stress_elastic( Ss, D, SsPrim, deltaSn,  Ctrl, ParMat, iErr )
      if( iErr/=0 ) iErr= 1
	   iNonl= 1
      iUpd= 1

   case default
      iErr= -99

   end select

end subroutine nmat3d_usd



subroutine get_stress_elastic( Ss, D, SsPrim, deltaSn, Ctrl, ParMat, iErr )
!
! PURPOSE: Hooke's law for given E, mue
!
   implicit none
   ! dummy parameters
   double precision, intent( out )     :: Ss(6)
   double precision, intent( inout )   :: D(6,6)
   double precision, intent( in )      :: SsPrim(6), deltaSn(6), ParMat(12)
   real, intent( in )                  :: Ctrl(5)
   integer, intent( out )              :: iErr
   ! internal
   double precision  :: G, fak, E, mue
   integer           :: i

   iErr= 0
   !check input parameters
   E= ParMat(1); mue= ParMat(2)
   if( E<=0.d0 )                    iErr= iErr + 1      !Young's modulus
   if( mue<0.d0 .or. mue>0.49d0 )   iErr= iErr + 2      !Poisson's ratio

   if( iErr==0 ) then
   !..establish constitutive
      G= 0.5d0*(1.d0-2.d0*mue)
      fak= E/(1.d0+mue)/(1.d0-2.d0*mue)
      D(:,:)= 0.d0
      do i=1,3
         D(i,i)= (1.d0-mue)*fak
         D(i+3,i+3)= G*fak
      enddo
      D(1,2:3)= mue*fak
      D(2:3,1)= mue*fak
      D(2,3)= mue*fak
      D(3,2)= mue*fak

   !..update stresses
      Ss(:)= SsPrim(:) + matmul(D, deltaSn)
   endif

end subroutine get_stress_elastic
