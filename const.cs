[Flags]
enum Days {
     NONE = 0b_000_000,
     SUN = 0b_000_001,
     MON = 0b_000_010,
     TUE = 0b_000_100,
     WED = 0b_001_000,
     THU = 0b_010_000,
    FRI = 0b_100_000,
     SAT = 0b_1_000_000,
    WEEKEND = FRI | SAT,
    WORKING = SUN | MON | TUE | WED | THU
}