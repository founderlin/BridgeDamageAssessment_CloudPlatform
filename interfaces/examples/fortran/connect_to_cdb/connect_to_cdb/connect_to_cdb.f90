!+============================================================================+
!| Company:   SOFiSTiK AG                                                     |
!| Version:   SOFiSTIK 2018                                                   |
!+============================================================================+
 
! ToDo (troubleshooting)
! ======================
! 1. Project Properties -> Fortran -> General -> Additional Include Directories and add 
!    "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018\interfaces\examples\fortran"
! 2. Copy all DLLs from "ANALYSIS_50_X64\interfaces\64bit_debug" to "...connect_to_cdb\connect_to_cdb\x64\Debug"
! 3. Copy the icudt57.dll, icuin57.dll and icuuc57.dll from "ANALYSIS_50_X64" to "...connect_to_cdb\x64\Debug" 
! 4. Project Properties -> Linker -> Input -> Additional Dependencies and add
!     "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018\interfaces\64bit_debug\cdb_w50_x64d.lib"
! 5. Add "C:\Program Files\SOFiSTiK\2018\SOFiSTiK 2018" to environment PATH variable (not required, but recommended)

    program connect_to_CDB
    implicit none
    
    ! Variables
    integer :: nid, l, ie, index, istat
    character(len=30)   :: filename
    character(len=72)   :: text

    index = 99
    filename = "connect_to_cdb.cdb"     ! input here the CDB name or the CDB path
    
    ! Connect to CDB
    ! In this example 64bit debug DLL is used
    call cdinit(filename, index)
    if (nid > 0) then
        write(*,*) "  cdb_init of ", filename," succesfull ", nid
    else   
        write(*,*) "  cdb_init of ", filename," not succesfull ", nid
    endif 
    
    ! Check status
    call cdstat(index, istat)
    print *, "CDB status is: ", istat
    
    ! Lets close the CDB now
    call cdclose(0)
    
    ! Check status again, if closed, status = 0
    call cdstat(index, istat)
    print *, "CDB status is: ", istat
    
    ! Press <ENTER> key to close the program
    print *, "Press <ENTER> key to close the program"
    read (*,*)

    end program connect_to_CDB

