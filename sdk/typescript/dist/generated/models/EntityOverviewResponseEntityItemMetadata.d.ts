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
import type { EntityMetadataItem } from './EntityMetadataItem';
/**
 *
 * @export
 * @interface EntityOverviewResponseEntityItemMetadata
 */
export interface EntityOverviewResponseEntityItemMetadata {
    /**
     * TBD (make it nullable when we're dealing with unknown result set sizes?)
     * @type {number}
     * @memberof EntityOverviewResponseEntityItemMetadata
     */
    total_count: number;
    /**
     * TBD (maybe we should use HATEOAS-like permalinks?)
     * @type {string}
     * @memberof EntityOverviewResponseEntityItemMetadata
     */
    previous_cursor?: string | null;
    /**
     * TBD (maybe we should use HATEOAS-like permalinks?)
     * @type {string}
     * @memberof EntityOverviewResponseEntityItemMetadata
     */
    next_cursor?: string | null;
    /**
     * TBD
     * @type {Array<EntityMetadataItem>}
     * @memberof EntityOverviewResponseEntityItemMetadata
     */
    items: Array<EntityMetadataItem>;
}
/**
 * Check if a given object implements the EntityOverviewResponseEntityItemMetadata interface.
 */
export declare function instanceOfEntityOverviewResponseEntityItemMetadata(value: object): boolean;
export declare function EntityOverviewResponseEntityItemMetadataFromJSON(json: any): EntityOverviewResponseEntityItemMetadata;
export declare function EntityOverviewResponseEntityItemMetadataFromJSONTyped(json: any, ignoreDiscriminator: boolean): EntityOverviewResponseEntityItemMetadata;
export declare function EntityOverviewResponseEntityItemMetadataToJSON(value?: EntityOverviewResponseEntityItemMetadata | null): any;
