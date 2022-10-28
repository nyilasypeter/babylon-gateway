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
import type { PartialLedgerStateIdentifier } from './PartialLedgerStateIdentifier';
import type { TransactionLookupIdentifier } from './TransactionLookupIdentifier';
/**
 *
 * @export
 * @interface TransactionDetailsRequest
 */
export interface TransactionDetailsRequest {
    /**
     *
     * @type {TransactionLookupIdentifier}
     * @memberof TransactionDetailsRequest
     */
    transaction_identifier: TransactionLookupIdentifier;
    /**
     *
     * @type {PartialLedgerStateIdentifier}
     * @memberof TransactionDetailsRequest
     */
    at_state_identifier?: PartialLedgerStateIdentifier | null;
}
/**
 * Check if a given object implements the TransactionDetailsRequest interface.
 */
export declare function instanceOfTransactionDetailsRequest(value: object): boolean;
export declare function TransactionDetailsRequestFromJSON(json: any): TransactionDetailsRequest;
export declare function TransactionDetailsRequestFromJSONTyped(json: any, ignoreDiscriminator: boolean): TransactionDetailsRequest;
export declare function TransactionDetailsRequestToJSON(value?: TransactionDetailsRequest | null): any;
