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
import type { NonFungibleIdType } from './NonFungibleIdType';
import {
    NonFungibleIdTypeFromJSON,
    NonFungibleIdTypeFromJSONTyped,
    NonFungibleIdTypeToJSON,
} from './NonFungibleIdType';

/**
 * 
 * @export
 * @interface StateEntityDetailsResponseNonFungibleResourceDetails
 */
export interface StateEntityDetailsResponseNonFungibleResourceDetails {
    /**
     * 
     * @type {string}
     * @memberof StateEntityDetailsResponseNonFungibleResourceDetails
     */
    type: StateEntityDetailsResponseNonFungibleResourceDetailsTypeEnum;
    /**
     * 
     * @type {object}
     * @memberof StateEntityDetailsResponseNonFungibleResourceDetails
     */
    access_rules_chain: object;
    /**
     * 
     * @type {object}
     * @memberof StateEntityDetailsResponseNonFungibleResourceDetails
     */
    vault_access_rules_chain: object;
    /**
     * 
     * @type {NonFungibleIdType}
     * @memberof StateEntityDetailsResponseNonFungibleResourceDetails
     */
    non_fungible_id_type: NonFungibleIdType;
    /**
     * String-encoded decimal representing the amount of a related fungible resource.
     * @type {string}
     * @memberof StateEntityDetailsResponseNonFungibleResourceDetails
     */
    total_supply: string;
    /**
     * String-encoded decimal representing the amount of a related fungible resource.
     * @type {string}
     * @memberof StateEntityDetailsResponseNonFungibleResourceDetails
     */
    total_minted: string;
    /**
     * String-encoded decimal representing the amount of a related fungible resource.
     * @type {string}
     * @memberof StateEntityDetailsResponseNonFungibleResourceDetails
     */
    total_burned: string;
}


/**
 * @export
 */
export const StateEntityDetailsResponseNonFungibleResourceDetailsTypeEnum = {
    NonFungibleResource: 'NonFungibleResource'
} as const;
export type StateEntityDetailsResponseNonFungibleResourceDetailsTypeEnum = typeof StateEntityDetailsResponseNonFungibleResourceDetailsTypeEnum[keyof typeof StateEntityDetailsResponseNonFungibleResourceDetailsTypeEnum];


/**
 * Check if a given object implements the StateEntityDetailsResponseNonFungibleResourceDetails interface.
 */
export function instanceOfStateEntityDetailsResponseNonFungibleResourceDetails(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "type" in value;
    isInstance = isInstance && "access_rules_chain" in value;
    isInstance = isInstance && "vault_access_rules_chain" in value;
    isInstance = isInstance && "non_fungible_id_type" in value;
    isInstance = isInstance && "total_supply" in value;
    isInstance = isInstance && "total_minted" in value;
    isInstance = isInstance && "total_burned" in value;

    return isInstance;
}

export function StateEntityDetailsResponseNonFungibleResourceDetailsFromJSON(json: any): StateEntityDetailsResponseNonFungibleResourceDetails {
    return StateEntityDetailsResponseNonFungibleResourceDetailsFromJSONTyped(json, false);
}

export function StateEntityDetailsResponseNonFungibleResourceDetailsFromJSONTyped(json: any, ignoreDiscriminator: boolean): StateEntityDetailsResponseNonFungibleResourceDetails {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'type': json['type'],
        'access_rules_chain': json['access_rules_chain'],
        'vault_access_rules_chain': json['vault_access_rules_chain'],
        'non_fungible_id_type': NonFungibleIdTypeFromJSON(json['non_fungible_id_type']),
        'total_supply': json['total_supply'],
        'total_minted': json['total_minted'],
        'total_burned': json['total_burned'],
    };
}

export function StateEntityDetailsResponseNonFungibleResourceDetailsToJSON(value?: StateEntityDetailsResponseNonFungibleResourceDetails | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'type': value.type,
        'access_rules_chain': value.access_rules_chain,
        'vault_access_rules_chain': value.vault_access_rules_chain,
        'non_fungible_id_type': NonFungibleIdTypeToJSON(value.non_fungible_id_type),
        'total_supply': value.total_supply,
        'total_minted': value.total_minted,
        'total_burned': value.total_burned,
    };
}

