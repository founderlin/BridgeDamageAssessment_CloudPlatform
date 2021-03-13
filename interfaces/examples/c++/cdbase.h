/* ------------------------------------------------------------------------ */
/* CDBASE - C-Version 4.0                                     30.09.1983    */
/* Copyright SOFiSTiK GmbH, 85764 Oberschleissheim                          */
/* ------------------------------------------------------------------------ */

#ifndef CDBASE_H_INCLUDED
#define CDBASE_H_INCLUDED

#ifdef __cplusplus
    extern "C" {
#endif                                                   /* __cplusplus */

#ifndef SOF_CDB_TYPES
#define CDB_INT int
#endif

#ifndef  CLIB_H_INCLUDED

#if !defined(SOF_C_DLL_API) // for dllinit.cpp and glib
#  if defined(_WIN32) && !defined(SCANTEXT_EXE_EXPORTS)
#     if defined(SOF_C_DLL_EXPORTS) || defined(SOF_CW_DLL_EXPORTS) || defined(SOF_Q_DLL_EXPORTS) || \
         defined(CDB_W_DLL_EXPORTS) || defined(CDB_W_EDU_DLL_EXPORTS)
#        define SOF_C_DLL_API __declspec(dllexport)
#     else
#        define SOF_C_DLL_API __declspec(dllimport)
#     endif
#  else
#     define SOF_C_DLL_API
#  endif
#endif
       typedef unsigned short unicode;       /* Unicode Strings 16 Bit   */
       typedef unsigned int pckcode;       /* Gepackter Unicode 32 Bit */

  extern void sof_lib_ps2cs ( const pckcode* p_str, char* c_str , int mlen );
                                              /* Pckstring -> Charstring    */
  extern void sof_lib_cs2ps ( const char* c_str, pckcode* e_str , int mlen );
                                              /* Charstring -> Pckstring    */
  extern void    sof_lib_4cpack  (int* p,const char* c);      /* 4 Char in int     */
  extern void    sof_lib_4cunpack  (const int* p,char* c);    /* 4 Char aus int    */
#endif

/**
 \addtogroup cdbase   CDBASE
	Allgemeine Informationen

	Falls die Routinen auf einen nicht behebbaren Fehler in der
	Datenbank stossen, werden alle Locks soweit als moeglich freigeben,
	alle Datenbanken und das gesamte CDBASE-System geschlossen.
	Danach wird mittels sof_lib_pstop das Programm beendet.
	sof_lib_pstop ruft am Ende sof_lib_pexit.

	Dort wird unter Windows	eine Exception geworfen !

	Falls die Routinen auf ein Lock stossen, wird der Benutzer mit einer
	Dialogbox darauf aufmerksam gemacht. Bricht der Benutzer hier ab,
	wird wie bei einem schweren Fehler weiterverfahren.
	
*/


typedef enum cd_error_t {
	CD_ERR_NONE = 0,
	CD_ERR_TOLONG = 1,
	CD_ERR_TOOLONG = 1,
	CD_ERR_DATAEND = 2,
	CD_ERR_NOTFOUND = 3,
	CD_ERR_NOLOCK = 4,
	CD_ERR_CDB_ERROR = 5,
    CD_ERR_NOFILE = 10,
    CD_ERR_CORRUPT = 99  /* Database is corrupt. user has to delete it */
} cd_err_type;


/**
 \ingroup cdbase   CDBASE

 Steuerung, ob CDBase rein informative Messages produziert
 ( Multi - Single- User, Memory, usw. )
 Default: level = CD_MSG_ON

 Steuerung Fehlerverhalten
 - CD_WANT_STOP default
	Alle Fehler rufen PSTOP/sof_lib_pstop
 - CD_WANT_RETURN
	Abbruch bei Lock erzeugt CD_ERR_NOLOCK
	Fehler in File erzeugt CD_ERR_CDB_ERROR

 \param level the new level
 \return   old locking status
 \return   -1 if some error

*/
SOF_C_DLL_API  int sof_cdb_msglevel( int level );
#define CD_MSG_ON   0
#define CD_MSG_OFF  1
#define CD_WANT_STOP       9
#define CD_WANT_RETURN     10
#define CD_WANT_TESTFOROPEN  12

// to be removed
#define CD_WANT_EXCEPTION  CD_WANT_RETURN

/**
 \ingroup cdbase   CDBASE
 define lock handling
 - CD_LOCK_DEFAULT  if lock found, show dialog and wait until lock possible.
				    user can abort using the dialog
 - CD_LOCK_NODIALOG if lock found, wait until lock possible.
					user can not abort, and doesn't know program is waiting
 - CD_LOCK_NOWAIT   if lock found return without waiting
 - CD_LOCK_ABORTWAIT if lock found return without waiting
 - CD_LOCK_ABORT    if lock found abort

 \param locking	the locking type
 \return   old locking status
 \return   -1 if some error
 */
SOF_C_DLL_API  int sof_cdb_setlockhandling( int locking );
#define CD_LOCK_DEFAULT    0
#define CD_LOCK_NODIALOG   1
#define CD_LOCK_NOWAIT     2
#define CD_LOCK_ABORT      3
#define CD_LOCK_ABORTWAIT  4

/**
 \ingroup cdbase   CDBASE
	liefert Namen der Datei bei index
 \param index offener index
 \return Name der Datei, die unter index geöffnet ist.
        NULL, falls keine Datei unter diesem Index offen
*/
SOF_C_DLL_API const char * sof_cdb_getname( int index );
SOF_C_DLL_API const unicode * sof_cdb_getname_u( int index );

/**
 \ingroup cdbase   CDBASE

 \param name  kompletter dateiname

 \return INDEX der Datei, falls diese Datei bereits offen ist.
 \return -1 falls nicht
*/
SOF_C_DLL_API int sof_cdb_isopen( const char *name );
#ifdef _WIN32
SOF_C_DLL_API int sof_cdb_isopen_u( const unicode *name );
#endif
/**
 \ingroup cdbase   CDBASE

 die Datei wird geoeffnet und automatisch aktuelle Datenbank

 \param filename vollstaendiger Dateiname gem. BS

 \param  nid = 0    nur System initialisieren und Scratchdatei oeffnen
 \param  nid = CD_OPEN_LOCAL   Datei testen, falls CDBASE-Datei Rueckgabe icd
 \param  nid = CD_OPEN_SERVER   Datei ueber den Server ansprechen
 \param  nid = CD_OPEN_SCRATCH   Scratchdatei oeffnen, Name wird als Pathangabe verwendet
            wird kein Name angegeben, so wird die datei auf
              CDBASETMP / TEMP / TMP / lokales Verzeichnis
            angelegt.
            Datei wird bei Close geloescht
 \param  nid = CD_OPEN_READONLY   Datei in Readonly oeffnen.
			Datei muss existieren.
			Leselocks werden eingetragen.
			Schreibversuche werden mit CD_ERR_NOTFOUND nicht ausgeführt,
			CDLOCK ebenso, CDFREE wird ausgeführt
			NEU: andere Programme dürfen mit CD_OPEN_LOCAL die datei geöffnet haben.
 \param  nid = CD_OPEN_LOCALNEW   Datei vorher löschen


 \return  <  0     Es ist ein Fehler aufgetreten, siehe clib1.h
 \return  >= 0     Index fuer die Zugriffe

\verbatim
#define SOF_ERR_CD_NOSCRATCH     (-256)  Scratch file could not be opened
                                         may be added to the following errors
#define SOF_ERR_UNKNOWN           (-16)  unknown error
#define SOF_ERR_PATHNOTFOUND      (-17)  path not valid
#define SOF_ERR_NAMENOTVALID      (-18)  Name not valid
#define SOF_ERR_FILENOTFOUND      (-27)  File not found
#define SOF_ERR_NOPERMISSION      (-28)  no permission to create file
#define SOF_ERR_TOOMANYOPENFILES  (-37)
#define SOF_ERR_NOWRITEPERMISSION (-38)  no permission to write file
#define SOF_ERR_CD_WRONGVERSION   (-47)  cdbase has wrong version
#define SOF_ERR_CD_WRONGFORMAT    (-48)  file has no cdbase format
\endverbatim


*/
SOF_C_DLL_API int sof_cdb_init ( const char*filename, int nid);
#ifdef _WIN32
SOF_C_DLL_API int sof_cdb_init_u ( const unicode *filename, int nid);
#endif
#define CD_OPEN_LOCAL       99
/*  98 for internal use */
#define CD_OPEN_SERVER      97
#define CD_OPEN_SCRATCH     96
#define CD_OPEN_READONLY    95
#define CD_OPEN_LOCALNEW    94

#ifdef __cplusplus
/**
\ingroup cdbase   CDBASE
Alle cdbase Zugriffe blockieren
typischerweise verwendet, wenn gerade gerechnet wird

alle sof_cdb_get, sof_cdb_put liefern CD_ERR_LOCK
alle get_update liefern 0

\param blocked blockieren
*/
SOF_C_DLL_API void sof_cdb_block(bool blocked);
SOF_C_DLL_API bool sof_cdb_isblocked();
SOF_C_DLL_API bool sof_cdb_isWaiting();
#endif

/**
\ingroup cdbase   CDBASE
alle bestehenden Locks werden freigeben,
alle eingelesenen Directories und Daten werden aus dem Speicher entfernt

\param Index == 0 fuer alle offenen Datenbanken
\param Index != 0 nur Datenbank Index

*/
SOF_C_DLL_API void sof_cdb_flush ( int Index );


/**
 \ingroup cdbase   CDBASE

die datenbank wurde im hintergrund geändert ohne CDB-System,
z.B. durch ein copy auf Filesystem ebene.
daher
- alle bestehenden Locks werden ignoriert
- alle eingelesenen Directories und Daten werden aus dem Speicher entfernt.
- Danach wird wie bei sof_cdb_init ganz von vorne begonnen.
\param Index == 0 fuer alle offenen Datenbanken
\param Index != 0 nur Datenbank Index
   */
SOF_C_DLL_API void sof_cdb_reset( int Index );


/**
 \ingroup cdbase   CDBASE
alle bestehenden Locks werden freigeben,
alle eingelesenen Directories und Daten werden aus dem Speicher entfernt
die Datenbank wird physikalisch geschlossen

\param Index == 0 fuer alle offenen Datenbanken
\param Index != 0 nur Datenbank Index

   */
SOF_C_DLL_API void sof_cdb_close ( int Index );

/**
 \ingroup cdbase   CDBASE
alle bestehenden Locks werden freigeben,
alle eingelesenen Directories und Daten werden aus dem Speicher entfernt
die Datenbank wird physikalisch geschlossen
auftretende Fehler werden gemeldet mit sof_lib_protokoll, ansonsten ignoriert
   */
SOF_C_DLL_API void sof_cdb_emergency_close ();

/**
 \ingroup cdbase   CDBASE
Schluessel kwh/kwl freigeben

kwh/kwl = 0/0 -> alle vom Benutzer gesperrten Schluessel freigeben
in aktiver Datenbank, bzw in Datenbank index
\param index datenbank
\param kwh kwl the key
   */
SOF_C_DLL_API void sof_cdb_free_ex (int index, int kwh, int kwl);
/**
 \ingroup cdbase   CDBASE
 \sa sof_cdb_free_ex
   */
SOF_C_DLL_API void sof_cdb_free (int kwh, int kwl);

/**
 \ingroup cdbase   CDBASE

Schluessel kwh/kwl sperren, muss explizit mit sof_cdb_free freigegeben werden
( sof_cdb_close machts natuerlich automatisch )

Diese Sperre wird durch sof_cdb_get* und sof_cdb_put* nicht veraendert.

kwh/kwl = 0/0 nicht zulaessig
in aktiver Datenbank, bzw in Datenbank index
   */
SOF_C_DLL_API enum cd_error_t sof_cdb_lock_ex (int index, int kwh, int kwl);
/**
 \ingroup cdbase   CDBASE
 \sa sof_cdb_lock_ex
   */
SOF_C_DLL_API cd_error_t sof_cdb_lock (int kwh, int kwl);

SOF_C_DLL_API cd_error_t sof_cdb_readlock_acquire(int index, int kwh, int kwl);
SOF_C_DLL_API cd_error_t sof_cdb_readlock_release(int index, int kwh, int kwl);

/**
 \ingroup cdbase   CDBASE
Schluessel kwh/kwl Mixlock setzen. Die daten werden gelöscht, daher keinen
call zum Löschen absetzen.

Muss mit sof_cdb_free explizit freigegeben werden.

in aktiver Datenbank, bzw in Datenbank index
   */
SOF_C_DLL_API void sof_cdb_mix_ex (int index, int kwh, int kwl);
/**
 \ingroup cdbase   CDBASE
 \sa sof_cdb_mix_ex
*/
SOF_C_DLL_API void sof_cdb_mix (int kwh, int kwl);

/**
 \ingroup cdbase   CDBASE
int sof_cdb_status ( int Index )

  - Index >= 0  der aktuelle Status der Datei bei Index wird zurueckgegeben.
    Index       Index der DB
    Status      Bitmuster
        CD_STATUS_AKTIV  CDBase ist aktiv
        CD_STATUS_OPEN   Index ist mit Datei verbunden
        CD_STATUS_SWAP   Fuer Datei muss ByteSwap beruecksichtigt werden
        CD_STATUS_READ   Datei wurde gelesen
        CD_STATUS_WRITE  Datei wurde geschrieben
        CD_STATUS_LOCK   fuer die Datei existieren Locks
        CD_STATUS_PVM    die Datei ist über PVM-Server geöffnet
        CD_STATUS_SCRATCH die Datei ist nur eine Scratchdatei
        CD_STATUS_READONLY die Datei ist nur Readonly
  - Index = -1
    return Index der aktiven Datenbank
           -1 = CDBase noch nicht eroeffnet
  - Index = -2
    return Maximalzahl gleichzeitig geöffneter Dateien

   */
SOF_C_DLL_API int sof_cdb_status (int);

#define CD_STATUSQ_AKTIV	-1
#define CD_STATUSQ_MAXFILES	-2

#define CD_STATUS_AKTIV    0x0001
#define CD_STATUS_OPEN     0x0002
#define CD_STATUS_SWAP     0x0004
#define CD_STATUS_READ     0x0008
#define CD_STATUS_WRITE    0x0010
#define CD_STATUS_LOCK     0x0020
#define CD_STATUS_PVM      0x0040
#define CD_STATUS_SCRATCH  0x0080
#define CD_STATUS_READONLY 0x0100

/**
 \ingroup cdbase   CDBASE
int sof_cdb_id( int Index )
return a unique id for this index.
if another database is opened with this index, the id changes
the id is only valid within the calling process

    Index       Index der DB
    return id

   */
SOF_C_DLL_API int sof_cdb_id(int);



/**
 \ingroup cdbase   CDBASE

Auswahl und Locking der aktiven DB
\param index >=0  Index der DB
\param index    -1  aktuelle Datenbank
\param il = 0  keine Aenderung dess Lockstatus
\param il     1  absolutes Filelocking
        moeglichst gleich vor dem ersten Aufruf,
        also besser nicht nachtraeglich umsetzten
\param il    -1  Filelocking freigeben
\param il     2  automatische Lockfreigabe von Readlocks deaktivieren
	    Readlocks werden beim Lesen des Datenendes normalerweise automatisch
		freigegeben
\param il	-2  automatische Lockfreigabe von Readlocks aktivieren

\return CD_ERR_NONE   ok
\return CD_ERR_NOFILE Index nicht gueltig
\return CD_ERR_NOLOCK absolutes filelocking nicht moeglich
   */

SOF_C_DLL_API enum cd_error_t sof_cdb_use (int index,int il);

/**
 \ingroup cdbase   CDBASE

Daten aus der aktuellen DB lesen

Es wird nur im Speicher gelesen.

Falls auch Datei durchsucht werden soll, muss sof_cdb_close vorher gemacht werden.

Beim ersten Zugriff wird die Lesesperre auf diesen KW gesetzt.

Bei Lesen des Datenendes wird diese Sperre freigegeben.

\param index  der datenbank index
\param     kwh      ( 0/0 nicht zulaessig )
\param     kwl      ( 0/0 nicht zulaessig )
\param s       Startadresse
\param ls      max. Recordlen in Byte !
        wird durch die aktuelle Laenge ueberschrieben
    = 0 Lesepointer setzen
\param nrew    Positionsanzeiger
    - < 0 Lese Record nrew Positionen vor der aktuellen Leseposition
        ( -1 = der zuletzt gelesene Record ).
        Leseposition wird nicht veraendert, wenn L > 0 ist.
    - = 0 Lese ersten Record (REWIND)
    - > 0 Lese naechsten Record ab aktueller Leseposition.
        Leseposition erhoeht sich um 1.
\return   CD_ERR_NONE     kein Fehler
\return   CD_ERR_TOOLONG  Record zu lang
\return   CD_ERR_DATAEND  Leseposition am Ende der Kennwortdatei
\return   CD_ERR_NOTFOUND KW existiert nicht

   ------------------------------------------------------------------------

cd_err_type sof_cdb_getsb( kwl, s, l, nrew )

analog, nur fuer Scratchdatei
kwh wird 0 gesetzt

analog, verwendeter Index ueber index, -1 ist aktiver Index

   */

SOF_C_DLL_API cd_err_type sof_cdb_get(int index, int kwh, int kwl, void *s, int *ls, int nrew);
/**
 \ingroup cdbase   CDBASE
 \sa sof_cdb_get
*/
SOF_C_DLL_API cd_err_type sof_cdb_getsb   (     int kwl, void *s, int *ls, int nrew);
/**
 \ingroup cdbase   CDBASE
 \sa sof_cdb_get
*/
SOF_C_DLL_API cd_err_type sof_cdb_getb    (int kwh, int kwl, void *s, int *ls, int nrew);

/**
 \ingroup cdbase   CDBASE
 \sa sof_cdb_get
*/
SOF_C_DLL_API cd_err_type sof_cdb_get_x( int index, int kwh, int kwl, void *data, int *len, int pos, int dest_version);


SOF_C_DLL_API bool sof_cdb_end_of_data(int cdb_index, int kwh, int kwl);

// Advance cdb position by n
SOF_C_DLL_API cd_err_type sof_cdb_advance(int cdb_index, int kwh, int kwl, int n);

/**
 \ingroup cdbase   CDBASE

Lesezeiger zurücksetzen

kwh/kwl == 0/0 nicht zulaessig

\param index   datenbank index
\param kwh  the key
\param kwl  the key

\return CD_ERR_NONE     kein Fehler
\return CD_ERR_DATAEND  Leseposition am Ende der Kennwortdatei
\return CD_ERR_NOTFOUND KW existiert nicht

   */
SOF_C_DLL_API cd_err_type sof_cdb_rewind_ex(int index, int kwh, int kwl);
/**
 \ingroup cdbase   CDBASE
 \sa sof_cdb_rewind_ex
*/
SOF_C_DLL_API cd_err_type sof_cdb_rewind(int kwh, int kwl);


/**
 \ingroup cdbase   CDBASE

Daten in die aktuelle DB schreiben

Beim ersten Zugriff wird die Schreibsperre auf diesen KW gesetzt.

Diese Sperre wird nicht selbstaendeg entfernt, sondern nur bei
sof_cdb_free und sof_cdb_close.

\param index  der datenbank index
\param      kwh      ( 0/0 nicht zulaessig )
\param      kwl      ( 0/0 nicht zulaessig )
\param s       Startadresse
\param ls      zu schreibende Recordlen in Byte !
\param nrew    Positionsanzeiger
    - < 0 Schreibe Record nrew Positionen vor der aktuellen Leseposition
        ( -1 = der zuletzt gelesene Record ).
        Leseposition wird nicht veraendert.
    - = 0 Schreibe ersten Record (REWIND).
        Alle alten Eintraege werden geloescht.
        falls ls = 0 entspricht dies einem Loeschen aller Daten.
    - > 0 Schreibe naechsten Record am Ende.
\return CD_ERR_NONE     kein Fehler
\return CD_ERR_TOOLONG  Record zu lang
                  ( bei nrew < 0 wurde versucht einen groesseren Satz
                  zurueckzuschreiben )
\return CD_ERR_DATAEND  Schreibposition nicht in der Kennwortdatei
\return  CD_ERR_NOTFOUND KW existiert nicht

   ------------------------------------------------------------------------

cd_err_type sof_cdb_putsb( int kwl, void *s, int *ls, int nrew )

analog, nur fuer Scratchdatei
kwh wird 0 gesetzt

cd_err_type sof_cdb_put( int index, int kwh, int kwl, void *s, int *ls, int nrew )

analog, verwendeter Index ueber index, -1 ist aktiver Index

   */

SOF_C_DLL_API cd_err_type sof_cdb_put(int index, int kwh, int kwl, const void *s, const int *ls, int nrew);
/**
 \ingroup cdbase   CDBASE
 \sa sof_cdb_put
*/
SOF_C_DLL_API cd_err_type sof_cdb_putb    (int kwh, int kwl, const void *s, const int *ls, int nrew);
/**
 \ingroup cdbase   CDBASE
 \sa sof_cdb_put
*/
SOF_C_DLL_API cd_err_type sof_cdb_putsb   (     int kwl, const void *s, const int *ls, int nrew);

/**
 \ingroup cdbase   CDBASE
loesche kwh/kwl in index
   */
SOF_C_DLL_API cd_err_type sof_cdb_del(int index, int kwh, int kwl);


/**
 \ingroup cdbase   CDBASE
kopiere von indexfrom kwhfrom/kwlfrom nach  indexto  kwhto/kwlto
   */
SOF_C_DLL_API cd_err_type sof_cdb_copy(int indexfrom, int kwhfrom, int kwlfrom, int indexto, int kwhto, int kwlto );

/**
 \ingroup cdbase   CDBASE
setze eine Versiosnummer zu einem KWH/KWL und loesche kwh/kwl in index
   */
SOF_C_DLL_API cd_err_type sof_cdb_putvers( int index, int kwh, int kwl, int version );

/**
 \ingroup cdbase   CDBASE
hole eine Versiosnummer zu einem KWH/KWL
   */
SOF_C_DLL_API cd_err_type sof_cdb_getvers( int index, int kwh, int kwl, int *version );


/**
 \ingroup cdbase   CDBASE
SOF_C_DLL_API int sof_cdb_getpos( int kwh, int kwl, int *pos1, int *pos2);
SOF_C_DLL_API int sof_cdb_setpos( int kwh, int kwl, int pos1, int pos2);
SOF_C_DLL_API int sof_cdb_getpos_ex( int index, int kwh, int kwl, int *pos1, int *pos2);
SOF_C_DLL_API int sof_cdb_setpos_ex( int index, int kwh, int kwl, int pos1, int pos2);

lese/setze aktuelle Leseposition
return TRUE falls erfolgreich
       FALSE falls Fehler auftraten
   */

SOF_C_DLL_API int sof_cdb_getpos( int kwh, int kwl, int *pos1, int *pos2);
SOF_C_DLL_API int sof_cdb_setpos( int kwh, int kwl, int pos1, int pos2);
SOF_C_DLL_API int sof_cdb_getpos_ex( int index, int kwh, int kwl, int *pos1, int *pos2);
SOF_C_DLL_API int sof_cdb_setpos_ex( int index, int kwh, int kwl, int pos1, int pos2);


/**
 \ingroup cdbase   CDBASE
void sof_cdb_kdef( int kwh, int kwl, int kwhd, int kwld)
void sof_cdb_kdef_ex( int index, int kwh, int kwl, int kwhd, int kwld)

definiere zu kwh/kwl(=Sohn)  kwhd/kwld(=Vater)
in aktiver Datenbank, bzw in Datenbank index
   */

SOF_C_DLL_API void sof_cdb_kdef (int, int, int, int);
SOF_C_DLL_API void sof_cdb_kdef_ex( int index, int, int, int, int);


/**
 \ingroup cdbase   CDBASE
loesche kwh/kwl und alle Nachkommen
zum loeschen eines einzigen Schluessels sollte besser sof_cdb_del verwendet werden
!! VOR dem Zugriff auf die Datenbank MUSS sof_cdb_use( *, 1 )
   aufgerufen worden sein, sonst wird nichts geloescht !!
in aktiver Datenbank, bzw in Datenbank index
   */

SOF_C_DLL_API void sof_cdb_kdel_ex( int index, int, int);
/**
 \ingroup cdbase   CDBASE
 \sa sof_cdb_kdel_ex
*/
SOF_C_DLL_API void sof_cdb_kdel (int, int);


/**
 \ingroup cdbase   CDBASE

Enquiry zu kwh/kwl
in aktiver Datenbank, bzw in Datenbank index
\param index  der datenbank index
\param      kwh      
\param      kwl      
\param isk
	  - CD_ENQ_EXTREMA    zulaessige Maximalwerte
      - CD_ENQ_DAD        Vaterschluessel

                        es werden nur Schluessel geliefert, die
                        Daten besitzen
      - CD_ENQ_NEXT       naechst hoehere Werte
                        nicht vorhandene Werte mit 0/0
      - CD_ENQ_PREV       naechst kleineren Wert in kwh/kwl
                        nicht vorhandene Werte mit 0/0
      - CD_ENQ_MIN        kleinsten definierter Wert zu kwh in kwl
                        nicht vorhandene Werte mit kwl=0
      - CD_ENQ_MAX        hoechster definierter Wert zu kwh in kwl
                        nicht vorhandene Werte mit kwl=0
      - CD_ENQ_MIN2       kleinsten definierter Wert zu kwh in kwl
                        nicht vorhandene Werte mit 0/0
      - CD_ENQ_MAX2       hoechster definierter Wert zu kwh in kwl
                        nicht vorhandene Werte mit 0/0

                        es werden auch Schluessel geliefert, die
                        keine Daten besitzen
      - CD_ENQ_NEXTX      naechst hoehere Werte
                        nicht vorhandene Werte mit 0/0
      - CD_ENQ_PREVX      naechst kleineren Wert in kwh/kwl
                        nicht vorhandene Werte mit 0/0
      - CD_ENQ_MINX       kleinsten definierter Wert zu kwh in kwl
                        nicht vorhandene Werte mit kwl=0
      - CD_ENQ_MAXX       hoechster definierter Wert zu kwh in kwl
                        nicht vorhandene Werte mit kwl=0


   */

SOF_C_DLL_API cd_err_type sof_cdb_enq (int index, int*kwh, int*kwl, int isk);
/**
 \ingroup cdbase   CDBASE
 \sa sof_cdb_kenq_ex
*/
SOF_C_DLL_API void sof_cdb_kenq_ex (int index, int*kwh, int*kwl, int isk);
SOF_C_DLL_API void sof_cdb_kenq (int*kwh, int*kwl, int isk);
#define CD_ENQ_EXTREMA   0
#define CD_ENQ_NEXT      1
#define CD_ENQ_PREV     -1
#define CD_ENQ_NEXTX     5
#define CD_ENQ_PREVX    -5
#define CD_ENQ_DAD       9
#define CD_ENQ_MIN      -2
#define CD_ENQ_MAX       2
#define CD_ENQ_MIN2     -3
#define CD_ENQ_MAX2      3
#define CD_ENQ_MINX     -6
#define CD_ENQ_MAXX      6

/**
 \ingroup cdbase   CDBASE
hole Aktualisierungsnummer von kwh/kwl
in aktiver Datenbank, bzw in Datenbank index

kwh/kwl = 0/0  Aktualisierungsnummer der Datenbank
\return 0     	      existiert nicht
\return  -updatenumber  existiert, hat aber keine Daten
\return  updatenumber  diese wird für jeden Schreibvorgang hochgezaehlt
	                  im Fall der Datenbank wird sie mit jedem neuen KW
					  hochgezaehlt
   */
SOF_C_DLL_API int sof_cdb_getupdate_ex( int index, int kwh, int kwl);
/**
 \ingroup cdbase   CDBASE
 \sa sof_cdb_getupdate_ex
*/
SOF_C_DLL_API int sof_cdb_getupdate( int kwh, int kwl);

/**
 \ingroup cdbase   CDBASE

Existiert kwh/kwl
in aktiver Datenbank, bzw in Datenbank index

\return  CD_EX_NOLOCK    Lock nicht erhalten. keine Information
\return  CD_EX_NO    	  exisitiert nicht
\return  CD_EX_YES   	  exisitiert
\return  CD_EX_YES_DATA exisitiert, Daten vorhanden
   */

SOF_C_DLL_API int sof_cdb_kexist_ex( int index, int kwh, int kwl);
/**
 \ingroup cdbase   CDBASE
 \sa sof_cdb_kexist_ex
*/
SOF_C_DLL_API int sof_cdb_kexist (int, int );
#define CD_EX_NOLOCK   -1
#define CD_EX_NO       0
#define CD_EX_YES      1
#define CD_EX_YES_DATA 2


/**
 \ingroup cdbase   CDBASE
in aktiver Datenbank alle locks entfernen
*/
void cd_Util_FreeForce();



/**
 \ingroup cdbase   CDBASE
		Passwortgeschützte Datenbanken

	Nur Datenbanken der Version 5* können mit Passwort geschützt werden.
	Insbesondere können diese nicht mehr mit alten Dlls gelesen werden.
	Dazu CDBASEVER=500 bzw 501 setzen VOR dem allerersten Datenbankzugriff.

	das Passwort darf maximal 8 Zeichen haben.

	Datenbank index mit einem passwort versehen.
	\param	index	the database
	\param oldpassword das bisherige password oder "" falls noch keines vergeben war
	\param password	das neue password oder "" falls es gelöscht werden soll
	\return		0 ok
	\return		1 datei nicht mit version 5 erzeugt
	\return		2 konnte Datei nicht exklusiv locken
	\return		3 falsches oldpassword
	\return		4 falsches passwordformat
	\return		5 falscher index
	\return		6 file readonly


*/

SOF_C_DLL_API int sof_cdb_setpassword( int index, const char *oldpassword, const char *password );
/**
 \ingroup cdbase   CDBASE
	Datenbank index auf passwort prüfen.
	\param	index	the database
	\param	password	das password oder "" falls keines erwartet ist
	\return		0 ok
					eine nicht geschützte Datei liefert immer OK
	\return		3 falsches password
	\return		5 falscher index
*/
SOF_C_DLL_API int sof_cdb_checkpassword( int index, const char *password );


#ifdef __cplusplus
    }
#endif                                                   /* __cplusplus */

#endif
