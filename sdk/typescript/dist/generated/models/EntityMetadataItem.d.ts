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
 * @interface EntityMetadataItem
 */
export interface EntityMetadataItem {
    /**
     *
     * @type {string}
     * @memberof EntityMetadataItem
     */
    key: string;
    /**
     *
     * @type {string}
     * @memberof EntityMetadataItem
     */
    value: string;
}
/**
 * Check if a given object implements the EntityMetadataItem interface.
 */
export declare function instanceOfEntityMetadataItem(value: object): boolean;
export declare function EntityMetadataItemFromJSON(json: any): EntityMetadataItem;
export declare function EntityMetadataItemFromJSONTyped(json: any, ignoreDiscriminator: boolean): EntityMetadataItem;
export declare function EntityMetadataItemToJSON(value?: EntityMetadataItem | null): any;
