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
 * @interface PublicKeyEddsaEd25519
 */
export interface PublicKeyEddsaEd25519 {
    /**
     * 
     * @type {string}
     * @memberof PublicKeyEddsaEd25519
     */
    key_type: PublicKeyEddsaEd25519KeyTypeEnum;
    /**
     * The hex-encoded compressed EdDSA Ed25519 public key (32 bytes)
     * @type {string}
     * @memberof PublicKeyEddsaEd25519
     */
    key_hex: string;
}


/**
 * @export
 */
export const PublicKeyEddsaEd25519KeyTypeEnum = {
    EddsaEd25519: 'EddsaEd25519'
} as const;
export type PublicKeyEddsaEd25519KeyTypeEnum = typeof PublicKeyEddsaEd25519KeyTypeEnum[keyof typeof PublicKeyEddsaEd25519KeyTypeEnum];


/**
 * Check if a given object implements the PublicKeyEddsaEd25519 interface.
 */
export function instanceOfPublicKeyEddsaEd25519(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "key_type" in value;
    isInstance = isInstance && "key_hex" in value;

    return isInstance;
}

export function PublicKeyEddsaEd25519FromJSON(json: any): PublicKeyEddsaEd25519 {
    return PublicKeyEddsaEd25519FromJSONTyped(json, false);
}

export function PublicKeyEddsaEd25519FromJSONTyped(json: any, ignoreDiscriminator: boolean): PublicKeyEddsaEd25519 {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'key_type': json['key_type'],
        'key_hex': json['key_hex'],
    };
}

export function PublicKeyEddsaEd25519ToJSON(value?: PublicKeyEddsaEd25519 | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'key_type': value.key_type,
        'key_hex': value.key_hex,
    };
}

