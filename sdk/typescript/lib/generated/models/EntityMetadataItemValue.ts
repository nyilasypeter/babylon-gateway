/* tslint:disable */
/* eslint-disable */
/**
 * Babylon Gateway API - RCnet V2
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers. For simple use cases, you can typically use the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs-babylon.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Integration and forward compatibility guarantees  We give no guarantees that other endpoints will not change before Babylon mainnet launch, although changes are expected to be minimal. 
 *
 * The version of the OpenAPI document: 0.4.0
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
 * @interface EntityMetadataItemValue
 */
export interface EntityMetadataItemValue {
    /**
     * 
     * @type {string}
     * @memberof EntityMetadataItemValue
     */
    raw_hex: string;
    /**
     * 
     * @type {object}
     * @memberof EntityMetadataItemValue
     */
    raw_json: object;
    /**
     * 
     * @type {string}
     * @memberof EntityMetadataItemValue
     */
    as_string?: string;
    /**
     * 
     * @type {Array<string>}
     * @memberof EntityMetadataItemValue
     */
    as_string_collection?: Array<string>;
}

/**
 * Check if a given object implements the EntityMetadataItemValue interface.
 */
export function instanceOfEntityMetadataItemValue(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "raw_hex" in value;
    isInstance = isInstance && "raw_json" in value;

    return isInstance;
}

export function EntityMetadataItemValueFromJSON(json: any): EntityMetadataItemValue {
    return EntityMetadataItemValueFromJSONTyped(json, false);
}

export function EntityMetadataItemValueFromJSONTyped(json: any, ignoreDiscriminator: boolean): EntityMetadataItemValue {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'raw_hex': json['raw_hex'],
        'raw_json': json['raw_json'],
        'as_string': !exists(json, 'as_string') ? undefined : json['as_string'],
        'as_string_collection': !exists(json, 'as_string_collection') ? undefined : json['as_string_collection'],
    };
}

export function EntityMetadataItemValueToJSON(value?: EntityMetadataItemValue | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'raw_hex': value.raw_hex,
        'raw_json': value.raw_json,
        'as_string': value.as_string,
        'as_string_collection': value.as_string_collection,
    };
}

