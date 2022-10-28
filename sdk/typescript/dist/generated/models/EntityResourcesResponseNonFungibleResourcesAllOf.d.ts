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
import type { EntityResourcesResponseNonFungibleResourcesItem } from './EntityResourcesResponseNonFungibleResourcesItem';
/**
 *
 * @export
 * @interface EntityResourcesResponseNonFungibleResourcesAllOf
 */
export interface EntityResourcesResponseNonFungibleResourcesAllOf {
    /**
     *
     * @type {Array<EntityResourcesResponseNonFungibleResourcesItem>}
     * @memberof EntityResourcesResponseNonFungibleResourcesAllOf
     */
    items: Array<EntityResourcesResponseNonFungibleResourcesItem>;
}
/**
 * Check if a given object implements the EntityResourcesResponseNonFungibleResourcesAllOf interface.
 */
export declare function instanceOfEntityResourcesResponseNonFungibleResourcesAllOf(value: object): boolean;
export declare function EntityResourcesResponseNonFungibleResourcesAllOfFromJSON(json: any): EntityResourcesResponseNonFungibleResourcesAllOf;
export declare function EntityResourcesResponseNonFungibleResourcesAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): EntityResourcesResponseNonFungibleResourcesAllOf;
export declare function EntityResourcesResponseNonFungibleResourcesAllOfToJSON(value?: EntityResourcesResponseNonFungibleResourcesAllOf | null): any;
