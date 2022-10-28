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
import type { EntityDetailsResponseDetails } from './EntityDetailsResponseDetails';
import type { EntityDetailsResponseMetadata } from './EntityDetailsResponseMetadata';
import type { LedgerState } from './LedgerState';
/**
 *
 * @export
 * @interface EntityDetailsResponse
 */
export interface EntityDetailsResponse {
    /**
     *
     * @type {LedgerState}
     * @memberof EntityDetailsResponse
     */
    ledger_state: LedgerState;
    /**
     * The Bech32m-encoded human readable version of the entity's global address
     * @type {string}
     * @memberof EntityDetailsResponse
     */
    address: string;
    /**
     *
     * @type {EntityDetailsResponseMetadata}
     * @memberof EntityDetailsResponse
     */
    metadata: EntityDetailsResponseMetadata;
    /**
     *
     * @type {EntityDetailsResponseDetails}
     * @memberof EntityDetailsResponse
     */
    details: EntityDetailsResponseDetails;
}
/**
 * Check if a given object implements the EntityDetailsResponse interface.
 */
export declare function instanceOfEntityDetailsResponse(value: object): boolean;
export declare function EntityDetailsResponseFromJSON(json: any): EntityDetailsResponse;
export declare function EntityDetailsResponseFromJSONTyped(json: any, ignoreDiscriminator: boolean): EntityDetailsResponse;
export declare function EntityDetailsResponseToJSON(value?: EntityDetailsResponse | null): any;
