#+============================================================================+
#| Company:   SOFiSTiK AG                                                     |
#| Version:   SOFiSTIK 2018                                                   |
#+============================================================================+

import os               # for the environment variable necessary
import platform         # checks the python platform

#########################
# Decode number to text
def lng2txt(curLong):
   part1 = (curLong & 0xFF000000) // 0x1000000 & 0xFF
   part2 = (curLong & 0xFF0000) // 0x10000
   part3 = (curLong & 0xFF00) // 0x100
   part4 = curLong & 0xFF

   decode = ""

   if part4 <> 0:
      decode = decode + chr(part4)
       
   if part3 <> 0:
      decode = decode + chr(part3)
   
   if part2 <> 0:
      decode = decode + chr(part2)
   
   if part1 <> 0:
      decode = decode + chr(part1)
   return decode;

# Test
print (lng2txt(540237639));

#########################
# Encode text to number
def txt2lng(txt):
   part1 = txt[0]
   part2 = txt[1]
   part3 = txt[2]
   part4 = txt[3]

   intpart1 = ord(part1)
   intpart2 = ord(part2) * 0x100 
   intpart3 = ord(part3) * 0x10000
   intpart4 = ord(part4) * 0x1000000
    
   out = intpart4 + intpart3 + intpart2 + intpart1
   return out;

# Test (do not forget the space characters)
print txt2lng("ZC  ")
print txt2lng("SF  ")
print txt2lng("L_T ")
print txt2lng("G_3 ")




