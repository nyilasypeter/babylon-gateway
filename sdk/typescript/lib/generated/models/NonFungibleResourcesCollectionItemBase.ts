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
import type { EntityMetadataCollection } from './EntityMetadataCollection';
import {
    EntityMetadataCollectionFromJSON,
    EntityMetadataCollectionFromJSONTyped,
    EntityMetadataCollectionToJSON,
} from './EntityMetadataCollection';
import type { ResourceAggregationLevel } from './ResourceAggregationLevel';
import {
    ResourceAggregationLevelFromJSON,
    ResourceAggregationLevelFromJSONTyped,
    ResourceAggregationLevelToJSON,
} from './ResourceAggregationLevel';

/**
 * 
 * @export
 * @interface NonFungibleResourcesCollectionItemBase
 */
export interface NonFungibleResourcesCollectionItemBase {
    /**
     * 
     * @type {ResourceAggregationLevel}
     * @memberof NonFungibleResourcesCollectionItemBase
     */
    aggregation_level: ResourceAggregationLevel;
    /**
     * Bech32m-encoded human readable version of the address.
     * @type {string}
     * @memberof NonFungibleResourcesCollectionItemBase
     */
    resource_address: string;
    /**
     * 
     * @type {EntityMetadataCollection}
     * @memberof NonFungibleResourcesCollectionItemBase
     */
    explicit_metadata?: EntityMetadataCollection;
}

/**
 * Check if a given object implements the NonFungibleResourcesCollectionItemBase interface.
 */
export function instanceOfNonFungibleResourcesCollectionItemBase(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "aggregation_level" in value;
    isInstance = isInstance && "resource_address" in value;

    return isInstance;
}

export function NonFungibleResourcesCollectionItemBaseFromJSON(json: any): NonFungibleResourcesCollectionItemBase {
    return NonFungibleResourcesCollectionItemBaseFromJSONTyped(json, false);
}

export function NonFungibleResourcesCollectionItemBaseFromJSONTyped(json: any, ignoreDiscriminator: boolean): NonFungibleResourcesCollectionItemBase {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'aggregation_level': ResourceAggregationLevelFromJSON(json['aggregation_level']),
        'resource_address': json['resource_address'],
        'explicit_metadata': !exists(json, 'explicit_metadata') ? undefined : EntityMetadataCollectionFromJSON(json['explicit_metadata']),
    };
}

export function NonFungibleResourcesCollectionItemBaseToJSON(value?: NonFungibleResourcesCollectionItemBase | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'aggregation_level': ResourceAggregationLevelToJSON(value.aggregation_level),
        'resource_address': value.resource_address,
        'explicit_metadata': EntityMetadataCollectionToJSON(value.explicit_metadata),
    };
}

