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
 */
export declare const EntityDetailsResponseDetailsType: {
    readonly FungibleResource: "fungible_resource";
    readonly NonFungibleResource: "non_fungible_resource";
    readonly AccountComponent: "account_component";
};
export declare type EntityDetailsResponseDetailsType = typeof EntityDetailsResponseDetailsType[keyof typeof EntityDetailsResponseDetailsType];
export declare function EntityDetailsResponseDetailsTypeFromJSON(json: any): EntityDetailsResponseDetailsType;
export declare function EntityDetailsResponseDetailsTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): EntityDetailsResponseDetailsType;
export declare function EntityDetailsResponseDetailsTypeToJSON(value?: EntityDetailsResponseDetailsType | null): any;
