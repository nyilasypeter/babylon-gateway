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
/**
 *
 * @export
 * @interface EntityDetailsResponseNonFungibleResourceDetailsIdsItem
 */
export interface EntityDetailsResponseNonFungibleResourceDetailsIdsItem {
    /**
     *
     * @type {string}
     * @memberof EntityDetailsResponseNonFungibleResourceDetailsIdsItem
     */
    id_hex?: string;
    /**
     *
     * @type {string}
     * @memberof EntityDetailsResponseNonFungibleResourceDetailsIdsItem
     */
    immutable_data_hex?: string;
    /**
     *
     * @type {string}
     * @memberof EntityDetailsResponseNonFungibleResourceDetailsIdsItem
     */
    mutable_data_hex?: string;
}
/**
 * Check if a given object implements the EntityDetailsResponseNonFungibleResourceDetailsIdsItem interface.
 */
export declare function instanceOfEntityDetailsResponseNonFungibleResourceDetailsIdsItem(value: object): boolean;
export declare function EntityDetailsResponseNonFungibleResourceDetailsIdsItemFromJSON(json: any): EntityDetailsResponseNonFungibleResourceDetailsIdsItem;
export declare function EntityDetailsResponseNonFungibleResourceDetailsIdsItemFromJSONTyped(json: any, ignoreDiscriminator: boolean): EntityDetailsResponseNonFungibleResourceDetailsIdsItem;
export declare function EntityDetailsResponseNonFungibleResourceDetailsIdsItemToJSON(value?: EntityDetailsResponseNonFungibleResourceDetailsIdsItem | null): any;
