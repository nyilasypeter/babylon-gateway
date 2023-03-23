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
import type { StateEntityDetailsResponseItemDetails } from './StateEntityDetailsResponseItemDetails';
import {
    StateEntityDetailsResponseItemDetailsFromJSON,
    StateEntityDetailsResponseItemDetailsFromJSONTyped,
    StateEntityDetailsResponseItemDetailsToJSON,
} from './StateEntityDetailsResponseItemDetails';
import type { StateEntityDetailsResponseItemDetailsType } from './StateEntityDetailsResponseItemDetailsType';
import {
    StateEntityDetailsResponseItemDetailsTypeFromJSON,
    StateEntityDetailsResponseItemDetailsTypeFromJSONTyped,
    StateEntityDetailsResponseItemDetailsTypeToJSON,
} from './StateEntityDetailsResponseItemDetailsType';

/**
 * 
 * @export
 * @interface StateEntityDetailsResponseFungibleResourceDetails
 */
export interface StateEntityDetailsResponseFungibleResourceDetails extends StateEntityDetailsResponseItemDetails {
    /**
     * 
     * @type {object}
     * @memberof StateEntityDetailsResponseFungibleResourceDetails
     */
    access_rules_chain: object;
    /**
     * 
     * @type {object}
     * @memberof StateEntityDetailsResponseFungibleResourceDetails
     */
    vault_access_rules_chain: object;
    /**
     * 
     * @type {number}
     * @memberof StateEntityDetailsResponseFungibleResourceDetails
     */
    divisibility: number;
}

/**
 * Check if a given object implements the StateEntityDetailsResponseFungibleResourceDetails interface.
 */
export function instanceOfStateEntityDetailsResponseFungibleResourceDetails(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "access_rules_chain" in value;
    isInstance = isInstance && "vault_access_rules_chain" in value;
    isInstance = isInstance && "divisibility" in value;

    return isInstance;
}

export function StateEntityDetailsResponseFungibleResourceDetailsFromJSON(json: any): StateEntityDetailsResponseFungibleResourceDetails {
    return StateEntityDetailsResponseFungibleResourceDetailsFromJSONTyped(json, false);
}

export function StateEntityDetailsResponseFungibleResourceDetailsFromJSONTyped(json: any, ignoreDiscriminator: boolean): StateEntityDetailsResponseFungibleResourceDetails {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        ...StateEntityDetailsResponseItemDetailsFromJSONTyped(json, ignoreDiscriminator),
        'access_rules_chain': json['access_rules_chain'],
        'vault_access_rules_chain': json['vault_access_rules_chain'],
        'divisibility': json['divisibility'],
    };
}

export function StateEntityDetailsResponseFungibleResourceDetailsToJSON(value?: StateEntityDetailsResponseFungibleResourceDetails | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        ...StateEntityDetailsResponseItemDetailsToJSON(value),
        'access_rules_chain': value.access_rules_chain,
        'vault_access_rules_chain': value.vault_access_rules_chain,
        'divisibility': value.divisibility,
    };
}
