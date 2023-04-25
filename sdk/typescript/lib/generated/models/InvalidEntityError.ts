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
 * @interface InvalidEntityError
 */
export interface InvalidEntityError {
    /**
     * 
     * @type {string}
     * @memberof InvalidEntityError
     */
    type: InvalidEntityErrorTypeEnum;
    /**
     * Bech32m-encoded human readable version of the entity's global address or hex-encoded id.
     * @type {string}
     * @memberof InvalidEntityError
     */
    address: string;
}


/**
 * @export
 */
export const InvalidEntityErrorTypeEnum = {
    InvalidEntityError: 'InvalidEntityError'
} as const;
export type InvalidEntityErrorTypeEnum = typeof InvalidEntityErrorTypeEnum[keyof typeof InvalidEntityErrorTypeEnum];


/**
 * Check if a given object implements the InvalidEntityError interface.
 */
export function instanceOfInvalidEntityError(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "type" in value;
    isInstance = isInstance && "address" in value;

    return isInstance;
}

export function InvalidEntityErrorFromJSON(json: any): InvalidEntityError {
    return InvalidEntityErrorFromJSONTyped(json, false);
}

export function InvalidEntityErrorFromJSONTyped(json: any, ignoreDiscriminator: boolean): InvalidEntityError {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'type': json['type'],
        'address': json['address'],
    };
}

export function InvalidEntityErrorToJSON(value?: InvalidEntityError | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'type': value.type,
        'address': value.address,
    };
}

