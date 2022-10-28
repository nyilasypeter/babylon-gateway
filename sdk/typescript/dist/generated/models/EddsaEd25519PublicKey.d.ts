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
 * @interface EddsaEd25519PublicKey
 */
export interface EddsaEd25519PublicKey {
    /**
     *
     * @type {string}
     * @memberof EddsaEd25519PublicKey
     */
    key_type: string;
    /**
     * The hex-encoded compressed EdDSA Ed25519 public key (32 bytes)
     * @type {string}
     * @memberof EddsaEd25519PublicKey
     */
    key_hex: string;
}
/**
 * Check if a given object implements the EddsaEd25519PublicKey interface.
 */
export declare function instanceOfEddsaEd25519PublicKey(value: object): boolean;
export declare function EddsaEd25519PublicKeyFromJSON(json: any): EddsaEd25519PublicKey;
export declare function EddsaEd25519PublicKeyFromJSONTyped(json: any, ignoreDiscriminator: boolean): EddsaEd25519PublicKey;
export declare function EddsaEd25519PublicKeyToJSON(value?: EddsaEd25519PublicKey | null): any;
