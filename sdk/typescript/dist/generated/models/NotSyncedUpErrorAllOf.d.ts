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
 * @interface NotSyncedUpErrorAllOf
 */
export interface NotSyncedUpErrorAllOf {
    /**
     * The request type that triggered this exception.
     * @type {string}
     * @memberof NotSyncedUpErrorAllOf
     */
    request_type: string;
    /**
     * The current delay between the Gateway DB and the network ledger round timestamp.
     * @type {number}
     * @memberof NotSyncedUpErrorAllOf
     */
    current_sync_delay_seconds: number;
    /**
     * The maximum allowed delay between the Gateway DB and the network ledger round timestamp for this `request_type`.
     * @type {number}
     * @memberof NotSyncedUpErrorAllOf
     */
    max_allowed_sync_delay_seconds: number;
}
/**
 * Check if a given object implements the NotSyncedUpErrorAllOf interface.
 */
export declare function instanceOfNotSyncedUpErrorAllOf(value: object): boolean;
export declare function NotSyncedUpErrorAllOfFromJSON(json: any): NotSyncedUpErrorAllOf;
export declare function NotSyncedUpErrorAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): NotSyncedUpErrorAllOf;
export declare function NotSyncedUpErrorAllOfToJSON(value?: NotSyncedUpErrorAllOf | null): any;
