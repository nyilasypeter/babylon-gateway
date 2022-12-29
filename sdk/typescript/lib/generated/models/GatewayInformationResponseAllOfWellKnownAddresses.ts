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
/**
 * 
 * @export
 * @interface GatewayInformationResponseAllOfWellKnownAddresses
 */
export interface GatewayInformationResponseAllOfWellKnownAddresses {
    /**
     * Bech32m-encoded human readable version of the entity's global address.
     * @type {string}
     * @memberof GatewayInformationResponseAllOfWellKnownAddresses
     */
    account_package: string;
    /**
     * Bech32m-encoded human readable version of the component (normal, account, system) global address.
     * @type {string}
     * @memberof GatewayInformationResponseAllOfWellKnownAddresses
     */
    faucet: string;
    /**
     * Bech32m-encoded human readable version of the entity's global address.
     * @type {string}
     * @memberof GatewayInformationResponseAllOfWellKnownAddresses
     */
    epoch_manager: string;
    /**
     * Bech32m-encoded human readable version of the entity's global address.
     * @type {string}
     * @memberof GatewayInformationResponseAllOfWellKnownAddresses
     */
    clock: string;
    /**
     * Bech32m-encoded human readable version of the resource (fungible, non-fungible) global address.
     * @type {string}
     * @memberof GatewayInformationResponseAllOfWellKnownAddresses
     */
    ecdsa_secp256k1: string;
    /**
     * Bech32m-encoded human readable version of the resource (fungible, non-fungible) global address.
     * @type {string}
     * @memberof GatewayInformationResponseAllOfWellKnownAddresses
     */
    eddsa_ed25519: string;
    /**
     * Bech32m-encoded human readable version of the resource (fungible, non-fungible) global address.
     * @type {string}
     * @memberof GatewayInformationResponseAllOfWellKnownAddresses
     */
    xrd: string;
}

/**
 * Check if a given object implements the GatewayInformationResponseAllOfWellKnownAddresses interface.
 */
export function instanceOfGatewayInformationResponseAllOfWellKnownAddresses(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "account_package" in value;
    isInstance = isInstance && "faucet" in value;
    isInstance = isInstance && "epoch_manager" in value;
    isInstance = isInstance && "clock" in value;
    isInstance = isInstance && "ecdsa_secp256k1" in value;
    isInstance = isInstance && "eddsa_ed25519" in value;
    isInstance = isInstance && "xrd" in value;

    return isInstance;
}

export function GatewayInformationResponseAllOfWellKnownAddressesFromJSON(json: any): GatewayInformationResponseAllOfWellKnownAddresses {
    return GatewayInformationResponseAllOfWellKnownAddressesFromJSONTyped(json, false);
}

export function GatewayInformationResponseAllOfWellKnownAddressesFromJSONTyped(json: any, ignoreDiscriminator: boolean): GatewayInformationResponseAllOfWellKnownAddresses {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'account_package': json['account_package'],
        'faucet': json['faucet'],
        'epoch_manager': json['epoch_manager'],
        'clock': json['clock'],
        'ecdsa_secp256k1': json['ecdsa_secp256k1'],
        'eddsa_ed25519': json['eddsa_ed25519'],
        'xrd': json['xrd'],
    };
}

export function GatewayInformationResponseAllOfWellKnownAddressesToJSON(value?: GatewayInformationResponseAllOfWellKnownAddresses | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'account_package': value.account_package,
        'faucet': value.faucet,
        'epoch_manager': value.epoch_manager,
        'clock': value.clock,
        'ecdsa_secp256k1': value.ecdsa_secp256k1,
        'eddsa_ed25519': value.eddsa_ed25519,
        'xrd': value.xrd,
    };
}
