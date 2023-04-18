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
import type { FungibleResourcesCollectionItemGloballyAggregated } from './FungibleResourcesCollectionItemGloballyAggregated';
import {
    FungibleResourcesCollectionItemGloballyAggregatedFromJSON,
    FungibleResourcesCollectionItemGloballyAggregatedFromJSONTyped,
    FungibleResourcesCollectionItemGloballyAggregatedToJSON,
} from './FungibleResourcesCollectionItemGloballyAggregated';

/**
 * 
 * @export
 * @interface StateEntityDetailsResponseComponentDetails
 */
export interface StateEntityDetailsResponseComponentDetails {
    /**
     * 
     * @type {string}
     * @memberof StateEntityDetailsResponseComponentDetails
     */
    type: StateEntityDetailsResponseComponentDetailsTypeEnum;
    /**
     * 
     * @type {object}
     * @memberof StateEntityDetailsResponseComponentDetails
     */
    access_rules_chain: object;
    /**
     * 
     * @type {string}
     * @memberof StateEntityDetailsResponseComponentDetails
     */
    blueprint_name: string;
    /**
     * Bech32m-encoded human readable version of the entity's global address or hex-encoded id.
     * @type {string}
     * @memberof StateEntityDetailsResponseComponentDetails
     */
    package_address?: string;
    /**
     * 
     * @type {FungibleResourcesCollectionItemGloballyAggregated}
     * @memberof StateEntityDetailsResponseComponentDetails
     */
    royalty_aggregator?: FungibleResourcesCollectionItemGloballyAggregated;
    /**
     * 
     * @type {object}
     * @memberof StateEntityDetailsResponseComponentDetails
     */
    state?: object;
}


/**
 * @export
 */
export const StateEntityDetailsResponseComponentDetailsTypeEnum = {
    Component: 'Component'
} as const;
export type StateEntityDetailsResponseComponentDetailsTypeEnum = typeof StateEntityDetailsResponseComponentDetailsTypeEnum[keyof typeof StateEntityDetailsResponseComponentDetailsTypeEnum];


/**
 * Check if a given object implements the StateEntityDetailsResponseComponentDetails interface.
 */
export function instanceOfStateEntityDetailsResponseComponentDetails(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "type" in value;
    isInstance = isInstance && "access_rules_chain" in value;
    isInstance = isInstance && "blueprint_name" in value;

    return isInstance;
}

export function StateEntityDetailsResponseComponentDetailsFromJSON(json: any): StateEntityDetailsResponseComponentDetails {
    return StateEntityDetailsResponseComponentDetailsFromJSONTyped(json, false);
}

export function StateEntityDetailsResponseComponentDetailsFromJSONTyped(json: any, ignoreDiscriminator: boolean): StateEntityDetailsResponseComponentDetails {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'type': json['type'],
        'access_rules_chain': json['access_rules_chain'],
        'blueprint_name': json['blueprint_name'],
        'package_address': !exists(json, 'package_address') ? undefined : json['package_address'],
        'royalty_aggregator': !exists(json, 'royalty_aggregator') ? undefined : FungibleResourcesCollectionItemGloballyAggregatedFromJSON(json['royalty_aggregator']),
        'state': !exists(json, 'state') ? undefined : json['state'],
    };
}

export function StateEntityDetailsResponseComponentDetailsToJSON(value?: StateEntityDetailsResponseComponentDetails | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'type': value.type,
        'access_rules_chain': value.access_rules_chain,
        'blueprint_name': value.blueprint_name,
        'package_address': value.package_address,
        'royalty_aggregator': FungibleResourcesCollectionItemGloballyAggregatedToJSON(value.royalty_aggregator),
        'state': value.state,
    };
}

