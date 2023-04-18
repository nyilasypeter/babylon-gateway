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
/**
 * 
 * @export
 * @interface StateNonFungibleDataRequestAllOf
 */
export interface StateNonFungibleDataRequestAllOf {
    /**
     * 
     * @type {Array<string>}
     * @memberof StateNonFungibleDataRequestAllOf
     */
    non_fungible_ids: Array<string>;
    /**
     * Bech32m-encoded human readable version of the resource (fungible, non-fungible) global address or hex-encoded id.
     * @type {string}
     * @memberof StateNonFungibleDataRequestAllOf
     */
    resource_address: string;
}

/**
 * Check if a given object implements the StateNonFungibleDataRequestAllOf interface.
 */
export function instanceOfStateNonFungibleDataRequestAllOf(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "non_fungible_ids" in value;
    isInstance = isInstance && "resource_address" in value;

    return isInstance;
}

export function StateNonFungibleDataRequestAllOfFromJSON(json: any): StateNonFungibleDataRequestAllOf {
    return StateNonFungibleDataRequestAllOfFromJSONTyped(json, false);
}

export function StateNonFungibleDataRequestAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): StateNonFungibleDataRequestAllOf {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'non_fungible_ids': json['non_fungible_ids'],
        'resource_address': json['resource_address'],
    };
}

export function StateNonFungibleDataRequestAllOfToJSON(value?: StateNonFungibleDataRequestAllOf | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'non_fungible_ids': value.non_fungible_ids,
        'resource_address': value.resource_address,
    };
}

