using System.Runtime.Serialization;

namespace MachineFileSanitizer;

[DataContract]
public class MachineImport
{
    [DataMember(Name = "ASSET")]
    public string? Asset { get; set; }
    [DataMember(Name = "AREA")]
    public string? Area { get; set; }
    [DataMember(Name = "Z")]
    public string? Z { get; set; }
    [DataMember(Name = "B")]
    public string? B { get; set; }
    [DataMember(Name = "L")]
    public string? L { get; set; }
    [DataMember(Name = "DENOM")]
    public string? Denom { get; set; }
    [DataMember(Name = "METER DENOM")]
    public string? Meterdenom { get; set; }
    [DataMember(Name = "MULTI DENOM")]
    public string? Multidenom { get; set; }
    [DataMember(Name = "MULTI DENOM SELECTION")]
    public string? Multidenomselection { get; set; }
    [DataMember(Name = "BANK CONFIG")]
    public string? Bankconfig { get; set; }
    [DataMember(Name = "MFR")]
    public string? Mfr { get; set; }
    [DataMember(Name = "MFR ID")]
    public string? Mfrid { get; set; }
    [DataMember(Name = "MODEL")]
    public string? Model { get; set; }
    [DataMember(Name = "MFR DATE")]
    public string? Mfrdate { get; set; }
    [DataMember(Name = "SERIES/FAMILY")]
    public string? Seriesfamily { get; set; }
    [DataMember(Name = "THEME")]
    public string? Theme { get; set; }
    [DataMember(Name = "MULTI GAME")]
    public string? Multigame { get; set; }
    [DataMember(Name = "SERIAL")]
    public string? Serial { get; set; }
    [DataMember(Name = "CABINET")]
    public string? Cabinet { get; set; }
    [DataMember(Name = "DEVICE TYPE")]
    public string? Devicetype { get; set; }
    [DataMember(Name = "IS VIDEO POKER")]
    public string? Isvideopoker { get; set; }
    [DataMember(Name = "GAME OWNERSHIP STATUS ")]
    public string? Gameownershipstatus { get; set; }
    [DataMember(Name = "GAME TYPE")]
    public string? Gametype { get; set; }
    [DataMember(Name = "SOFTWARE OWNERSHIP STATUS ")]
    public string? Softwareownershipstatus { get; set; }
    [DataMember(Name = "DISPLAY TYPE")]
    public string? Displaytype { get; set; }
    [DataMember(Name = "SPECIALTY PUPD")]
    public string? Specialtypupd { get; set; }
    [DataMember(Name = "PAYTABLE PROGRAM (MASTERPROM)")]
    public string? Paytableprogrammasterprom { get; set; }
    [DataMember(Name = "OPERATING SYSTEM (GAMEPROM)")]
    public string? Operatingsystemgameprom { get; set; }
    [DataMember(Name = "BOOT/BIOS")]
    public string? Bootbios { get; set; }
    [DataMember(Name = "BIOS/JURISTICTIONAL")]
    public string? Biosjuristictional { get; set; }
    [DataMember(Name = "COMM.")]
    public string? Comm { get; set; }
    [DataMember(Name = "PRINTER TYPE")]
    public string? Printertype { get; set; }
    [DataMember(Name = "PRINTER FIRMWARE")]
    public string? Printerfirmware { get; set; }
    [DataMember(Name = "BV TYPE")]
    public string? Bvtype { get; set; }
    [DataMember(Name = "BV FIRMWARE")]
    public string? Bvfirmware { get; set; }
    [DataMember(Name = "Paytable ID")]
    public string? PaytableId { get; set; }
    [DataMember(Name = "RTP")]
    public string? Rtp { get; set; }
    [DataMember(Name = "HOLD")]
    public string? Hold { get; set; }
    [DataMember(Name = "ADJ RTP")]
    public string? Adjrtp { get; set; }
    [DataMember(Name = "ADJ HOLD")]
    public string? Adjhold { get; set; }
    [DataMember(Name = "BET TYPE")]
    public string? Bettype { get; set; }
    [DataMember(Name = "MIN BET")]
    public string? Minbet { get; set; }
    [DataMember(Name = "MAX BET")]
    public string? Maxbet { get; set; }
    [DataMember(Name = "TOP AWARD")]
    public string? Topaward { get; set; }
    [DataMember(Name = "PROGRESSIVE TYPE")]
    public string? Progressivetype { get; set; }
    [DataMember(Name = "PROGRESSIVE LINK ID")]
    public string? Progressivelinkid { get; set; }
    [DataMember(Name = "PROGRESSIVE INTERGRATED Y/N")]
    public string? Progressiveintergratedyn { get; set; }
    [DataMember(Name = "EXTERNAL PROGRESSIVE CONTROLLER AND SOFTWARE")]
    public string? Externalprogressivecontrollerandsoftware { get; set; }
    [DataMember(Name = "LEVEL 0 RESET")]
    public string? Level0Reset { get; set; }
    [DataMember(Name = "LEVEL 0 LIMIT")]
    public string? Level0Limit { get; set; }
    [DataMember(Name = "LEVEL 0 INCREMENT %")]
    public string? Level0Incrementpercent { get; set; }
    [DataMember(Name = "LEVEL 1 RESET")]
    public string? Level1Reset { get; set; }
    [DataMember(Name = "LEVEL 1 LIMIT")]
    public string? Level1Limit { get; set; }
    [DataMember(Name = "LEVEL 1 INCREMENT %")]
    public string? Level1Incrementpercent { get; set; }
    [DataMember(Name = "LEVEL 2 RESET")]
    public string? Level2Reset { get; set; }
    [DataMember(Name = "LEVEL 2 LIMIT")]
    public string? Level2Limit { get; set; }
    [DataMember(Name = "LEVEL 2 INCREMENT %")]
    public string? Level2Incrementpercent { get; set; }
    [DataMember(Name = "LEVEL 3 RESET")]
    public string? Level3Reset { get; set; }
    [DataMember(Name = "LEVEL 3 LIMIT")]
    public string? Level3Limit { get; set; }
    [DataMember(Name = "LEVEL 3 INCREMENT %")]
    public string? Level3Incrementpercent { get; set; }
    [DataMember(Name = "LEVEL 4 RESET")]
    public string? Level4Reset { get; set; }
    [DataMember(Name = "LEVEL 4 LIMIT")]
    public string? Level4Limit { get; set; }
    [DataMember(Name = "LEVEL 4 INCREMENT %")]
    public string? Level4Incrementpercent { get; set; }
    [DataMember(Name = "LEVEL 5 RESET")]
    public string? Level5Reset { get; set; }
    [DataMember(Name = "LEVEL 5 LIMIT")]
    public string? Level5Limit { get; set; }
    [DataMember(Name = "LEVEL 5 INCREMENT %")]
    public string? Level5Incrementpercent { get; set; }
    [DataMember(Name = "LEVEL 6 RESET")]
    public string? Level6Reset { get; set; }
    [DataMember(Name = "LEVEL 6 LIMIT")]
    public string? Level6Limit { get; set; }
    [DataMember(Name = "LEVEL 6 INCREMENT %")]
    public string? Level6Incrementpercent { get; set; }
    [DataMember(Name = "LEVEL 7 RESET")]
    public string? Level7Reset { get; set; }
    [DataMember(Name = "LEVEL 7 LIMIT")]
    public string? Level7Limit { get; set; }
    [DataMember(Name = "LEVEL 7 INCREMENT %")]
    public string? Level7Incrementpercent { get; set; }
    [DataMember(Name = "LEVEL 8 RESET")]
    public string? Level8Reset { get; set; }
    [DataMember(Name = "LEVEL 8 LIMIT")]
    public string? Level8Limit { get; set; }
    [DataMember(Name = "LEVEL 8 INCREMENT %")]
    public string? Level8Incrementpercent { get; set; }
    [DataMember(Name = "LEVEL 9 RESET")]
    public string? Level9Reset { get; set; }
    [DataMember(Name = "LEVEL 9 LIMIT")]
    public string? Level9Limit { get; set; }
    [DataMember(Name = "LEVEL 9 INCREMENT %")]
    public string? Level9Incrementpercent { get; set; }
    [DataMember(Name = "CASH BOX TYPE")]
    public string? Cashboxtype { get; set; }
    [DataMember(Name = "FINANCE ASSET TAG")]
    public string? Financeassettag { get; set; }
    [DataMember(Name = "TOGO TAG #")]
    public string? Togotag { get; set; }
    [DataMember(Name = "ADOG TAG #")]
    public string? Adogtag { get; set; }
    [DataMember(Name = "FULL PAYTABLE PROGRAM (MASTERPROM)")]
    public string? Fullpaytableprogrammasterprom { get; set; }
    [DataMember(Name = "FULL OPERATING SYSTEM (GAMEPROM)")]
    public string? Fulloperatingsystemgameprom { get; set; }
    [DataMember(Name = "FREE PLAY ENABLED")]
    public string? Freeplayenabled { get; set; }
    [DataMember(Name = "4% CRITERIA MET")]
    public string? Fourpercentcriteriamet { get; set; }
    [DataMember(Name = "OUT FOR COVID")]
    public string? Outforcovid { get; set; }
    [DataMember(Name = "4% ADJUSTMENT NOTES")]
    public string? Fourpercentadjustmentnotes { get; set; }
}