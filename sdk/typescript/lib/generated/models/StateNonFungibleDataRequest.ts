/* tslint:disable */
/* eslint-disable */
/**
 * Babylon Gateway API - RCnet V1
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers. For simple use cases, you can typically use the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs-babylon.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Integration and forward compatibility guarantees  We give no guarantees that other endpoints will not change before Babylon mainnet launch, although changes are expected to be minimal. 
 *
 * The version of the OpenAPI document: 0.3.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
import type { LedgerStateSelector } from './LedgerStateSelector';
import {
    LedgerStateSelectorFromJSON,
    LedgerStateSelectorFromJSONTyped,
    LedgerStateSelectorToJSON,
} from './LedgerStateSelector';

/**
 * 
 * @export
 * @interface StateNonFungibleDataRequest
 */
export interface StateNonFungibleDataRequest {
    /**
     * 
     * @type {LedgerStateSelector}
     * @memberof StateNonFungibleDataRequest
     */
    at_ledger_state?: LedgerStateSelector | null;
    /**
     * This cursor allows forward pagination, by providing the cursor from the previous request.
     * @type {string}
     * @memberof StateNonFungibleDataRequest
     */
    cursor?: string | null;
    /**
     * The page size requested.
     * @type {number}
     * @memberof StateNonFungibleDataRequest
     */
    limit_per_page?: number | null;
    /**
     * Bech32m-encoded human readable version of the resource (fungible, non-fungible) global address or hex-encoded id.
     * @type {string}
     * @memberof StateNonFungibleDataRequest
     */
    resource_address: string;
    /**
     * 
     * @type {Array<string>}
     * @memberof StateNonFungibleDataRequest
     */
    non_fungible_ids: Array<string>;
}

/**
 * Check if a given object implements the StateNonFungibleDataRequest interface.
 */
export function instanceOfStateNonFungibleDataRequest(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "resource_address" in value;
    isInstance = isInstance && "non_fungible_ids" in value;

    return isInstance;
}

export function StateNonFungibleDataRequestFromJSON(json: any): StateNonFungibleDataRequest {
    return StateNonFungibleDataRequestFromJSONTyped(json, false);
}

export function StateNonFungibleDataRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): StateNonFungibleDataRequest {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'at_ledger_state': !exists(json, 'at_ledger_state') ? undefined : LedgerStateSelectorFromJSON(json['at_ledger_state']),
        'cursor': !exists(json, 'cursor') ? undefined : json['cursor'],
        'limit_per_page': !exists(json, 'limit_per_page') ? undefined : json['limit_per_page'],
        'resource_address': json['resource_address'],
        'non_fungible_ids': json['non_fungible_ids'],
    };
}

export function StateNonFungibleDataRequestToJSON(value?: StateNonFungibleDataRequest | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'at_ledger_state': LedgerStateSelectorToJSON(value.at_ledger_state),
        'cursor': value.cursor,
        'limit_per_page': value.limit_per_page,
        'resource_address': value.resource_address,
        'non_fungible_ids': value.non_fungible_ids,
    };
}

