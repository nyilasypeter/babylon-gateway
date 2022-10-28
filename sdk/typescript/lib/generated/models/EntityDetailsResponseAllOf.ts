/* tslint:disable */
/* eslint-disable */
/**
 * Radix Babylon Gateway API
 * See https://docs.radixdlt.com/main/apis/introduction.html 
 *
 * The version of the OpenAPI document: 2.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
import type { EntityDetailsResponseDetails } from './EntityDetailsResponseDetails';
import {
    EntityDetailsResponseDetailsFromJSON,
    EntityDetailsResponseDetailsFromJSONTyped,
    EntityDetailsResponseDetailsToJSON,
} from './EntityDetailsResponseDetails';
import type { EntityDetailsResponseMetadata } from './EntityDetailsResponseMetadata';
import {
    EntityDetailsResponseMetadataFromJSON,
    EntityDetailsResponseMetadataFromJSONTyped,
    EntityDetailsResponseMetadataToJSON,
} from './EntityDetailsResponseMetadata';

/**
 * 
 * @export
 * @interface EntityDetailsResponseAllOf
 */
export interface EntityDetailsResponseAllOf {
    /**
     * The Bech32m-encoded human readable version of the entity's global address
     * @type {string}
     * @memberof EntityDetailsResponseAllOf
     */
    address: string;
    /**
     * 
     * @type {EntityDetailsResponseMetadata}
     * @memberof EntityDetailsResponseAllOf
     */
    metadata: EntityDetailsResponseMetadata;
    /**
     * 
     * @type {EntityDetailsResponseDetails}
     * @memberof EntityDetailsResponseAllOf
     */
    details: EntityDetailsResponseDetails;
}

/**
 * Check if a given object implements the EntityDetailsResponseAllOf interface.
 */
export function instanceOfEntityDetailsResponseAllOf(value: object): boolean {
    let isInstance = true;
    isInstance = isInstance && "address" in value;
    isInstance = isInstance && "metadata" in value;
    isInstance = isInstance && "details" in value;

    return isInstance;
}

export function EntityDetailsResponseAllOfFromJSON(json: any): EntityDetailsResponseAllOf {
    return EntityDetailsResponseAllOfFromJSONTyped(json, false);
}

export function EntityDetailsResponseAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): EntityDetailsResponseAllOf {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'address': json['address'],
        'metadata': EntityDetailsResponseMetadataFromJSON(json['metadata']),
        'details': EntityDetailsResponseDetailsFromJSON(json['details']),
    };
}

export function EntityDetailsResponseAllOfToJSON(value?: EntityDetailsResponseAllOf | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'address': value.address,
        'metadata': EntityDetailsResponseMetadataToJSON(value.metadata),
        'details': EntityDetailsResponseDetailsToJSON(value.details),
    };
}

