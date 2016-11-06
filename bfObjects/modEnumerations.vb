Public Module modEnumerations

    Public Enum MarketBettingType
        ODDS = 1
        LINE = 2
        RANGE = 3
        ASIAN_HANDICAP_DOUBLE_LINE = 4
        ASIAN_HANDICAP_SINGLE_LINE = 5
        FIXED_ODDS = 6
    End Enum

    Public Enum MarketSort
        MINIMUM_TRADED = 1
        MAXIMUM_TRADED = 2
        MINIMUM_AVAILABLE = 3
        MAXIMUM_AVAILABLE = 4
        FIRST_TO_START = 5
        LAST_TO_START = 6
    End Enum


End Module
