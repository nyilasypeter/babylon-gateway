/* tslint:disable */
/* eslint-disable */
/**
 * Babylon Gateway API - RCnet V2
 * This API is exposed by the Babylon Radix Gateway to enable clients to efficiently query current and historic state on the RadixDLT ledger, and intelligently handle transaction submission.  It is designed for use by wallets and explorers. For simple use cases, you can typically use the Core API on a Node. A Gateway is only needed for reading historic snapshots of ledger states or a more robust set-up.  The Gateway API is implemented by the [Network Gateway](https://github.com/radixdlt/babylon-gateway), which is configured to read from [full node(s)](https://github.com/radixdlt/babylon-node) to extract and index data from the network.  This document is an API reference documentation, visit [User Guide](https://docs-babylon.radixdlt.com/) to learn more about how to run a Gateway of your own.  ## Integration and forward compatibility guarantees  We give no guarantees that other endpoints will not change before Babylon mainnet launch, although changes are expected to be minimal. 
 *
 * The version of the OpenAPI document: 0.4.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
/**
 * 
 * @export
 * @interface StateEntityDetailsOptIns
 */
export interface StateEntityDetailsOptIns {
    /**
     * 
     * @type {boolean}
     * @memberof StateEntityDetailsOptIns
     */
    ancestor_identities?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof StateEntityDetailsOptIns
     */
    component_royalty_vault_balance?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof StateEntityDetailsOptIns
     */
    package_royalty_vault_balance?: boolean;
    /**
     * 
     * @type {boolean}
     * @memberof StateEntityDetailsOptIns
     */
    non_fungible_include_nfids?: boolean;
    /**
     * 
     * @type {Array<string>}
     * @memberof StateEntityDetailsOptIns
     */
    explicit_metadata?: Array<string>;
}

/**
 * Check if a given object implements the StateEntityDetailsOptIns interface.
 */
export function instanceOfStateEntityDetailsOptIns(value: object): boolean {
    let isInstance = true;

    return isInstance;
}

export function StateEntityDetailsOptInsFromJSON(json: any): StateEntityDetailsOptIns {
    return StateEntityDetailsOptInsFromJSONTyped(json, false);
}

export function StateEntityDetailsOptInsFromJSONTyped(json: any, ignoreDiscriminator: boolean): StateEntityDetailsOptIns {
    if ((json === undefined) || (json === null)) {
        return json;
    }
    return {
        
        'ancestor_identities': !exists(json, 'ancestor_identities') ? undefined : json['ancestor_identities'],
        'component_royalty_vault_balance': !exists(json, 'component_royalty_vault_balance') ? undefined : json['component_royalty_vault_balance'],
        'package_royalty_vault_balance': !exists(json, 'package_royalty_vault_balance') ? undefined : json['package_royalty_vault_balance'],
        'non_fungible_include_nfids': !exists(json, 'non_fungible_include_nfids') ? undefined : json['non_fungible_include_nfids'],
        'explicit_metadata': !exists(json, 'explicit_metadata') ? undefined : json['explicit_metadata'],
    };
}

export function StateEntityDetailsOptInsToJSON(value?: StateEntityDetailsOptIns | null): any {
    if (value === undefined) {
        return undefined;
    }
    if (value === null) {
        return null;
    }
    return {
        
        'ancestor_identities': value.ancestor_identities,
        'component_royalty_vault_balance': value.component_royalty_vault_balance,
        'package_royalty_vault_balance': value.package_royalty_vault_balance,
        'non_fungible_include_nfids': value.non_fungible_include_nfids,
        'explicit_metadata': value.explicit_metadata,
    };
}

