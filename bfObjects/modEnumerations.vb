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


    Public Enum enumMarketProjection As Integer

        'If not selected then the competition will not be returned with marketCatalogue
        COMPETITION = 0
        'If not selected then the event will not be returned with marketCatalogue.
        [EVENT] = 1
        'If not selected then the eventType will not be returned with marketCatalogue.
        EVENT_TYPE = 2
        'If not selected then the start time will not be returned with marketCatalogue.
        MARKET_START_TIME = 3
        'If not selected then the description will not be returned with marketCatalogue.
        MARKET_DESCRIPTION = 4
        'If not selected then the runners will not be returned with marketCatalogue.
        RUNNER_DESCRIPTION = 5
        'If not selected then the runner metadata will not be returned with marketCatalogue. If selected then RUNNER_DESCRIPTION will also be returned regardless of whether it is included as a market projection.
        RUNNER_METADATA = 6

    End Enum

    Public Enum enumPriceData As Integer

        'Amount available for the BSP auction.
        SP_AVAILABLE = 0
        'Amount traded in the BSP auction.
        SP_TRADED = 1
        'Only the best prices available for each runner, to requested price depth.
        EX_BEST_OFFERS = 2
        'EX_ALL_OFFERS trumps EX_BEST_OFFERS if both settings are present.
        EX_ALL_OFFERS = 3
        'Amount traded on the exchange.
        EX_TRADED = 4

    End Enum

    Public Enum enumMatchProjection As Integer

        'No rollup, return raw fragments.
        NO_ROLLUP = 0
        'Rollup matched amounts by distinct matched prices per side.
        ROLLED_UP_BY_PRICE = 1
        'Rollup matched amounts by average matched price per side.
        ROLLED_UP_BY_AVG_PRICE = 2

    End Enum

    Public Enum enumOrderProjection As Integer
        'An order that has a remaining unmatched portion.
        EXECUTABLE = 0
        'An order that does not have any remaining unmatched portion.
        EXECUTION_COMPLETE = 1
        'EXECUTABLE and EXECUTION_COMPLETE orders.
        ALL = 2
    End Enum

    Public Enum enumMarketStatus As Integer
        'The market has been created but isn’t yet available.
        INACTIVE = 0
        'The market is open for betting.
        OPEN = 1
        'The market is suspended and not available for betting.
        SUSPENDED = 2
        'The market has been settled and is no longer available for betting.
        CLOSED = 3
    End Enum


    Public Enum enumRunnerStatus As Integer
        'ACTIVE
        ACTIVE = 0
        'WINNER
        WINNER = 1
        'LOSER
        LOSER = 2
        'REMOVED_VACANT applies to Greyhounds. Greyhound markets always return a fixed number of runners (traps). If a dog has been removed, the trap is shown as vacant.
        REMOVED_VACANT = 3
        'REMOVED
        REMOVED = 4
        'The selection is hidden from the market. This occurs in Horse Racing markets were runners is hidden when it is doesn’t hold an official entry following an entry stage. This could be because the horse was never entered or because they have been scratched from a race at a declaration stage. All matched customer bet prices are set to 1.0 even if there are later supplementary stages. Should it appear likely that a specific runner may actually be supplemented into the race this runner will be reinstated with all matched customer bets set back to the original prices.
        HIDDEN = 5
    End Enum

    Public Enum enumTimeGranularity As Integer
        'DAYS
        DAYS = 0
        'HOURS
        HOURS = 1
        'MINUTES
        MINUTES = 2
    End Enum

    Public Enum enumSide As Integer
        'To back a team, horse or outcome is to bet on the selection to win.
        BACK = 0
        'To lay a team, horse, or outcome is to bet on the selection to lose.
        LAY = 1
    End Enum

    Public Enum enumOrderStatus As Integer
        'An order that does not have any remaining unmatched portion.
        EXECUTION_COMPLETE = 0
        'An order that has a remaining unmatched portion.
        EXECUTABLE = 1
    End Enum

    Public Enum enumOrderBy As Integer
        'Order by market id, then placed time, then bet id.
        BY_MARKET = 0
        'Order by time of last matched fragment (if any), then placed time, then bet id. Filters out orders which have no matched date. The dateRange filter (if specified) is applied to the matched date.
        BY_MATCH_TIME = 1
        'Order by placed time, then bet id. This is an alias of to be deprecated BY_BET. The dateRange filter (if specified) is applied to the placed date.
        BY_PLACE_TIME = 2
        'Order by time of last settled fragment (if any due to partial market settlement), then by last match time, then placed time, then bet id. Filters out orders which have not been settled. The dateRange filter (if specified) is applied to the settled date.
        BY_SETTLED_TIME = 3
        'Order by time of last voided fragment (if any), then by last match time, then placed time, then bet id. Filters out orders which have not been voided. The dateRange filter (if specified) is applied to the voided date.
        BY_VOID_TIME = 4
    End Enum


    Public Enum enumSortDir As Integer
        'Order from earliest value to latest e.g. lowest betId is first in the results.
        EARLIEST_TO_LATEST = 0
        'Order from the latest value to the earliest e.g. highest betId is first in the results.
        LATEST_TO_EARLIEST = 1
    End Enum

    Public Enum enumOrderType As Integer
        'A normal exchange limit order for immediate execution.
        LIMIT = 0
        'Limit order for the auction (SP).
        LIMIT_ON_CLOSE = 1
        'Market order for the auction (SP).
        MARKET_ON_CLOSE = 2
    End Enum

    Public Enum enumMarketSort As Integer
        '◦Minimum traded volume
        MINIMUM_TRADED = 0
        'Maximum traded volume
        MAXIMUM_TRADED = 1
        'Minimum available to match
        MINIMUM_AVAILABLE = 2
        'The closest markets based on their expected start time.
        FIRST_TO_START = 3
        'The most distant markets based on their expected start time.
        LAST_TO_START = 4
    End Enum

    Public Enum enumMarketBettingType As Integer
        'Odds Market
        ODDS = 0
        'Line Market
        LINE = 1
        'Range Market
        RANGE = 2
        'Asian Handicap Market
        ASIAN_HANDICAP_DOUBLE_LINE = 3
        'Asian Single Line Market
        ASIAN_HANDICAP_SINGLE_LINE = 4
        'Sportsbook Odds Market. This type is deprecated and will be removed in future releases, when Sportsbook markets will be represented as ODDS market but with a different product type.
        FIXED_ODDS = 5

    End Enum

    Public Enum enumExecutionReportStatus As Integer
        'Order processed successfully
        SUCCESS = 0
        'Order failed
        FAILURE = 1
        'The order itself has been accepted, but at least one (possibly all) actions have generated errors. This error only occurs for replaceOrders, cancelOrders and updateOrders operations. The placeOrders operation will not return PROCESSED_WITH_ERRORS status as it is an atomic operation
        PROCESSED_WITH_ERRORS = 2
        'Order timed out.
        TIMEOUT = 3
    End Enum


    Public Enum enumExecutionReportErrorCode As Integer
        'The matcher is not healthy
        ERROR_IN_MATCHER = 0

        'The order itself has been accepted, but at least one (possibly all) actions have generated errors
        PROCESSED_WITH_ERRORS = 1

        'There is an error with an action that has caused the entire order to be rejected. Check the instructionReports errorCode for the reason for the rejection of the order.
        BET_ACTION_ERROR = 2

        'Order rejected due to the account’s status (suspended, inactive, dup cards)
        INVALID_ACCOUNT_STATE = 3

        'Order rejected due to the account’s wallet’s status
        INVALID_WALLET_STATUS = 4

        'Account has exceeded its exposure limit or available to bet limit
        INSUFFICIENT_FUNDS = 5

        'The account has exceed the self imposed loss limit
        LOSS_LIMIT_EXCEEDED = 6

        'Market is suspended
        MARKET_SUSPENDED = 7

        'Market is not open for betting. It is either not yet active, suspended or closed awaiting settlement.
        MARKET_NOT_OPEN_FOR_BETTING = 8

        'Duplicate customer reference data submitted - Please note: There is a time window associated with the de-duplication of duplicate submissions which is 60 second
        DUPLICATE_TRANSACTION = 9

        'Order cannot be accepted by the matcher due to the combination of actions. For example, bets being edited are not on the same market, or order includes both edits and placement
        INVALID_ORDER = 10

        'Market doesn’t exist
        INVALID_MARKET_ID = 11

        'Business rules do not allow order to be placed. You are either attempting to place the order using a Delayed Application Key or from a restricted jurisdiction (i.e. USA)
        PERMISSION_DENIED = 12

        'duplicate bet ids found
        DUPLICATE_BETIDS = 13

        'Order hasn’t been passed to matcher as system detected there will be no state change
        NO_ACTION_REQUIRED = 14

        'The requested service is unavailable
        SERVICE_UNAVAILABLE = 15

        'The regulator rejected the order. On the Italian Exchange this error will occur if more than 50 bets are sent in a single placeOrders request.
        REJECTED_BY_REGULATOR = 16

    End Enum

    Public Enum enumPersistenceType As Integer
        'Lapse the order when the market is turned in-play
        LAPSE = 0

        'Persist the order to in-play. The bet will be place automatically into the in-play market at the start of the event.
        PERSIST = 1

        'Put the order into the auction (SP) at turn-in-play
        MARKET_ON_CLOSE = 2
    End Enum


    Public Enum enumInstructionReportStatus As Integer
        'SUCCESS
        SUCCESS = 0
        'FAILURE
        FAILURE = 1
        'TIMEOUT
        TIMEOUT = 2
    End Enum


    Public Enum enumInstructionReportErrorCode As Integer

        'bet size is invalid for your currency or your regulator
        INVALID_BET_SIZE = 0

        'Runner does not exist, includes vacant traps in greyhound racing
        INVALID_RUNNER = 1

        'Bet cannot be cancelled or modified as it has already been taken or has lapsed Includes attempts to cancel/modify market on close BSP bets and cancelling limit on close BSP bets
        BET_TAKEN_OR_LAPSED = 2

        'No result was received from the matcher in a timeout configured for the system
        BET_IN_PROGRESS = 3

        'Runner has been removed from the event
        RUNNER_REMOVED = 4

        'Attempt to edit a bet on a market that has closed.
        MARKET_NOT_OPEN_FOR_BETTING = 5

        'The action has caused the account to exceed the self imposed loss limit
        LOSS_LIMIT_EXCEEDED = 6

        'Market now closed to bsp betting. Turned in-play or has been reconciled
        MARKET_NOT_OPEN_FOR_BSP_BETTING = 7

        'Attempt to edit down the price of a bsp limit on close lay bet, or edit up the price of a limit on close back bet
        INVALID_PRICE_EDIT = 8

        'Odds not on price ladder - either edit or placement
        INVALID_ODDS = 9

        'Insufficient funds available to cover the bet action. Either the exposure limit or available to bet limit would be exceeded
        INSUFFICIENT_FUNDS = 10

        'Invalid persistence type for this market, e.g. KEEP for a non bsp market
        INVALID_PERSISTENCE_TYPE = 11

        'A problem with the matcher prevented this action completing successfully
        ERROR_IN_MATCHER = 12

        'The order contains a back and a lay for the same runner at overlapping prices. This would guarantee a self match. This also applies to BSP limit on close bets
        INVALID_BACK_LAY_COMBINATION = 13

        'The action failed because the parent order failed
        ERROR_IN_ORDER = 14

        'Bid type is mandatory
        INVALID_BID_TYPE = 15

        'Bet for id supplied has not been found
        INVALID_BET_ID = 16

        'Bet cancelled but replacement bet was not placed
        CANCELLED_NOT_PLACED = 17

        'Action failed due to the failure of a action on which this action is dependent
        RELATED_ACTION_FAILED = 18

        'the action does not result in any state change. eg changing a persistence to it’s current value
        NO_ACTION_REQUIRED = 19

    End Enum

    Public Enum enumRollupModel As Integer
        'The volumes will be rolled up to the minimum value which is >= rollupLimit.
        STAKE = 0
        'The volumes will be rolled up to the minimum value where the payout( price * volume ) is >= rollupLimit.
        PAYOUT = 1
        'The volumes will be rolled up to the minimum value which is >= rollupLimit, until a lay price threshold. There after, the volumes will be rolled up to the minimum value such that the liability >= a minimum liability. Not supported as yet.
        MANAGED_LIABILITY = 2
        'No rollup will be applied. However the volumes will be filtered by currency specific minimum stake unless overridden specifically for the channel.
        NONE = 3
    End Enum


    Public Enum enumGroupBy As Integer
        'A roll up of settled P&L, commission paid and number of bet orders, on a specified event type
        EVENT_TYPE = 0

        'A roll up of settled P&L, commission paid and number of bet orders, on a specified event
        [EVENT] = 1

        'A roll up of settled P&L, commission paid and number of bet orders, on a specified market
        MARKET = 2

        'An averaged roll up of settled P&L, and number of bets, on the specified side of a specified selection within a specified market, that are either settled or voided
        SIDE = 3

        'The P&L, commission paid, side and regulatory information etc, about each individual bet order
        BET = 4

    End Enum



    Public Enum enumBetStatus As Integer

        'A matched bet that was settled normally
        SETTLED = 0

        'A matched bet that was subsequently voided by Betfair, before, during or after settlement
        VOIDED = 1

        'Unmatched bet that was cancelled by Betfair (for example at turn in play).
        LAPSED = 2

        'Unmatched bet that was cancelled by an explicit customer action.
        CANCELLED = 3

    End Enum


End Module
