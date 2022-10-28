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
import type { EntityOverviewResponseEntityItem } from './EntityOverviewResponseEntityItem';
import type { LedgerState } from './LedgerState';
/**
 *
 * @export
 * @interface EntityOverviewResponse
 */
export interface EntityOverviewResponse {
    /**
     *
     * @type {LedgerState}
     * @memberof EntityOverviewResponse
     */
    ledger_state: LedgerState;
    /**
     *
     * @type {Array<EntityOverviewResponseEntityItem>}
     * @memberof EntityOverviewResponse
     */
    entities: Array<EntityOverviewResponseEntityItem>;
}
/**
 * Check if a given object implements the EntityOverviewResponse interface.
 */
export declare function instanceOfEntityOverviewResponse(value: object): boolean;
export declare function EntityOverviewResponseFromJSON(json: any): EntityOverviewResponse;
export declare function EntityOverviewResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): EntityOverviewResponse;
export declare function EntityOverviewResponseToJSON(value?: EntityOverviewResponse | null): any;
