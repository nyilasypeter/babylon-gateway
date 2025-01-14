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

import {
    PublicKeyEcdsaSecp256k1,
    instanceOfPublicKeyEcdsaSecp256k1,
    PublicKeyEcdsaSecp256k1FromJSON,
    PublicKeyEcdsaSecp256k1FromJSONTyped,
    PublicKeyEcdsaSecp256k1ToJSON,
} from './PublicKeyEcdsaSecp256k1';
import {
    PublicKeyEddsaEd25519,
    instanceOfPublicKeyEddsaEd25519,
    PublicKeyEddsaEd25519FromJSON,
    PublicKeyEddsaEd25519FromJSONTyped,
    PublicKeyEddsaEd25519ToJSON,
} from './PublicKeyEddsaEd25519';

/**
 * @type PublicKey
 * 
 * @export
 */
export type PublicKey = { key_type: 'EcdsaSecp256k1' } & PublicKeyEcdsaSecp256k1 | { key_type: 'EddsaEd25519' } & PublicKeyEddsaEd25519;

export function PublicKeyFromJSON(json: any): PublicKey {
    return PublicKeyFromJSONTyped(json, false);
}

export function PublicKeyFromJSONTyped(json: any, ignoreDiscriminator: boolean): PublicKey {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    switch (json['key_type']) {
        case 'EcdsaSecp256k1':
            return {...PublicKeyEcdsaSecp256k1FromJSONTyped(json, true), key_type: 'EcdsaSecp256k1'};
        case 'EddsaEd25519':
            return {...PublicKeyEddsaEd25519FromJSONTyped(json, true), key_type: 'EddsaEd25519'};
        default:
            throw new Error(`No variant of PublicKey exists with 'key_type=${json['key_type']}'`);
    }
}

export function PublicKeyToJSON(value?: PublicKey | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    switch (value['key_type']) {
        case 'EcdsaSecp256k1':
            return PublicKeyEcdsaSecp256k1ToJSON(value);
        case 'EddsaEd25519':
            return PublicKeyEddsaEd25519ToJSON(value);
        default:
            throw new Error(`No variant of PublicKey exists with 'key_type=${value['key_type']}'`);
    }

}

