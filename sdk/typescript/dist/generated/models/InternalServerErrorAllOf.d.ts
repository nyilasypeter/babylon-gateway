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
 * @interface InternalServerErrorAllOf
 */
export interface InternalServerErrorAllOf {
    /**
     * Gives an error type which occurred within the Gateway API when serving the request.
     * @type {string}
     * @memberof InternalServerErrorAllOf
     */
    exception: string;
    /**
     * Gives a human readable message - likely just a trace ID for reporting the error.
     * @type {string}
     * @memberof InternalServerErrorAllOf
     */
    cause: string;
}
/**
 * Check if a given object implements the InternalServerErrorAllOf interface.
 */
export declare function instanceOfInternalServerErrorAllOf(value: object): boolean;
export declare function InternalServerErrorAllOfFromJSON(json: any): InternalServerErrorAllOf;
export declare function InternalServerErrorAllOfFromJSONTyped(json: any, ignoreDiscriminator: boolean): InternalServerErrorAllOf;
export declare function InternalServerErrorAllOfToJSON(value?: InternalServerErrorAllOf | null): any;
