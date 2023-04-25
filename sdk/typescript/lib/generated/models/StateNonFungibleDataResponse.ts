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
import type { LedgerState } from './LedgerState';
import {
    LedgerStateFromJSON,
    LedgerStateFromJSONTyped,
    LedgerStateToJSON,
} from './LedgerState';
import type { NonFungibleIdType } from './NonFungibleIdType';
import {
    NonFungibleIdTypeFromJSON,
    NonFungibleIdTypeFromJSONTyped,
    NonFungibleIdTypeToJSON,
} from './NonFungibleIdType';
import type { StateNonFungibleDetailsResponseItem } from './StateNonFungibleDetailsResponseItem';
import {
    StateNonFungibleDetailsResponseItemFromJSON,
    StateNonFungibleDetailsResponseItemFromJSONTyped,
    StateNonFungibleDetailsResponseItemToJSON,
} from './StateNonFungibleDetailsResponseItem';

/**
 * 
 * @export
 * @interface StateNonFungibleDataResponse
 */
export interface StateNonFungibleDataResponse {
    /**
     * 
     * @type {LedgerState}
     * @memberof StateNonFungibleDataResponse
     */
    ledger_state: LedgerState;
    /**
     * Bech32m-encoded human readable version of the resource (fungible, non-fungible) global address or hex-encoded id.
     * @type {string}
     * @memberof StateNonFungibleDataResponse
     */
    resource_address: string;
    /**
     * 
     * @type {NonFungibleIdType}
     * @memberof StateNonFungibleDataResponse
     */
    non_fungible_id_type: NonFungibleIdType;
    /**
     * 
     * @type {Array<StateNonFungibleDetailsResponseItem>}
     * @memberof StateNonFungibleDataResponse
     */
    non_fungible_ids: Array<StateNonFungibleDetailsResponseItem>;
}

/**
 * Check if a given object implements the StateNonFungibleDataResponse interface.
 */
export function instanceOfStateNonFungibleDataResponse(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "ledger_state" in value;
    isInstance = isInstance && "resource_address" in value;
    isInstance = isInstance && "non_fungible_id_type" in value;
    isInstance = isInstance && "non_fungible_ids" in value;

    return isInstance;
}

export function StateNonFungibleDataResponseFromJSON(json: any): StateNonFungibleDataResponse {
    return StateNonFungibleDataResponseFromJSONTyped(json, false);
}

export function StateNonFungibleDataResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): StateNonFungibleDataResponse {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'ledger_state': LedgerStateFromJSON(json['ledger_state']),
        'resource_address': json['resource_address'],
        'non_fungible_id_type': NonFungibleIdTypeFromJSON(json['non_fungible_id_type']),
        'non_fungible_ids': ((json['non_fungible_ids'] as Array<any>).map(StateNonFungibleDetailsResponseItemFromJSON)),
    };
}

export function StateNonFungibleDataResponseToJSON(value?: StateNonFungibleDataResponse | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'ledger_state': LedgerStateToJSON(value.ledger_state),
        'resource_address': value.resource_address,
        'non_fungible_id_type': NonFungibleIdTypeToJSON(value.non_fungible_id_type),
        'non_fungible_ids': ((value.non_fungible_ids as Array<any>).map(StateNonFungibleDetailsResponseItemToJSON)),
    };
}

