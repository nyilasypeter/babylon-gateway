/* tslint:disable */
/* eslint-disable */
/**
 * Radix Babylon Gateway API
 * This API is designed to enable clients to efficiently query information on the RadixDLT ledger, and allow clients to build and submit transactions to the network. It is designed for use by wallets and explorers.  This document is an API reference documentation, visit [User Guide](https://docs.radixdlt.com/main/apis/gateway-api.html) to learn more about different usage scenarios.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network. 
 *
 * The version of the OpenAPI document: 0.1.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
import type { NonFungibleIdsCollection } from './NonFungibleIdsCollection';
import {
    NonFungibleIdsCollectionFromJSON,
    NonFungibleIdsCollectionFromJSONTyped,
    NonFungibleIdsCollectionToJSON,
} from './NonFungibleIdsCollection';

/**
 * 
 * @export
 * @interface EntityNonFungibleIdsResponseAllOf
 */
export interface EntityNonFungibleIdsResponseAllOf {
    /**
     * Bech32m-encoded human readable version of the entity's global address.
     * @type {string}
     * @memberof EntityNonFungibleIdsResponseAllOf
     */
    address: string;
    /**
     * Bech32m-encoded human readable version of the resource (fungible, non-fungible) global address.
     * @type {string}
     * @memberof EntityNonFungibleIdsResponseAllOf
     */
    resource_address: string;
    /**
     * 
     * @type {NonFungibleIdsCollection}
     * @memberof EntityNonFungibleIdsResponseAllOf
     */
    non_fungible_ids: NonFungibleIdsCollection;
}

/**
 * Check if a given object implements the EntityNonFungibleIdsResponseAllOf interface.
 */
export function instanceOfEntityNonFungibleIdsResponseAllOf(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "address" in value;
    isInstance = isInstance && "resource_address" in value;
    isInstance = isInstance && "non_fungible_ids" in value;

    return isInstance;
}

export function EntityNonFungibleIdsResponseAllOfFromJSON(json: any): EntityNonFungibleIdsResponseAllOf {
    return EntityNonFungibleIdsResponseAllOfFromJSONTyped(json, false);
}

export function EntityNonFungibleIdsResponseAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): EntityNonFungibleIdsResponseAllOf {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'address': json['address'],
        'resource_address': json['resource_address'],
        'non_fungible_ids': NonFungibleIdsCollectionFromJSON(json['non_fungible_ids']),
    };
}

export function EntityNonFungibleIdsResponseAllOfToJSON(value?: EntityNonFungibleIdsResponseAllOf | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'address': value.address,
        'resource_address': value.resource_address,
        'non_fungible_ids': NonFungibleIdsCollectionToJSON(value.non_fungible_ids),
    };
}
