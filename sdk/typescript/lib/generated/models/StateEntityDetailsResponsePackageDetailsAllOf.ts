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
 * @interface StateEntityDetailsResponsePackageDetailsAllOf
 */
export interface StateEntityDetailsResponsePackageDetailsAllOf {
    /**
     * Hex-encoded binary blob.
     * @type {string}
     * @memberof StateEntityDetailsResponsePackageDetailsAllOf
     */
    code_hex?: string;
    /**
     * 
     * @type {FungibleResourcesCollectionItemGloballyAggregated}
     * @memberof StateEntityDetailsResponsePackageDetailsAllOf
     */
    royalty_aggregator?: FungibleResourcesCollectionItemGloballyAggregated;
    /**
     * 
     * @type {string}
     * @memberof StateEntityDetailsResponsePackageDetailsAllOf
     */
    type?: StateEntityDetailsResponsePackageDetailsAllOfTypeEnum;
}


/**
 * @export
 */
export const StateEntityDetailsResponsePackageDetailsAllOfTypeEnum = {
    Package: 'Package'
} as const;
export type StateEntityDetailsResponsePackageDetailsAllOfTypeEnum = typeof StateEntityDetailsResponsePackageDetailsAllOfTypeEnum[keyof typeof StateEntityDetailsResponsePackageDetailsAllOfTypeEnum];


/**
 * Check if a given object implements the StateEntityDetailsResponsePackageDetailsAllOf interface.
 */
export function instanceOfStateEntityDetailsResponsePackageDetailsAllOf(value: object): boolean {
    let isInstance = true;

    return isInstance;
}

export function StateEntityDetailsResponsePackageDetailsAllOfFromJSON(json: any): StateEntityDetailsResponsePackageDetailsAllOf {
    return StateEntityDetailsResponsePackageDetailsAllOfFromJSONTyped(json, false);
}

export function StateEntityDetailsResponsePackageDetailsAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): StateEntityDetailsResponsePackageDetailsAllOf {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'code_hex': !exists(json, 'code_hex') ? undefined : json['code_hex'],
        'royalty_aggregator': !exists(json, 'royalty_aggregator') ? undefined : FungibleResourcesCollectionItemGloballyAggregatedFromJSON(json['royalty_aggregator']),
        'type': !exists(json, 'type') ? undefined : json['type'],
    };
}

export function StateEntityDetailsResponsePackageDetailsAllOfToJSON(value?: StateEntityDetailsResponsePackageDetailsAllOf | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'code_hex': value.code_hex,
        'royalty_aggregator': FungibleResourcesCollectionItemGloballyAggregatedToJSON(value.royalty_aggregator),
        'type': value.type,
    };
}

