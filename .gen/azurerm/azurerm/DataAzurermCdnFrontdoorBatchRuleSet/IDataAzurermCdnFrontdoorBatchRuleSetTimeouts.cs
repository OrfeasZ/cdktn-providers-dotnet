using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCdnFrontdoorBatchRuleSet
{
    [JsiiInterface(nativeType: typeof(IDataAzurermCdnFrontdoorBatchRuleSetTimeouts), fullyQualifiedName: "azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetTimeouts")]
    public interface IDataAzurermCdnFrontdoorBatchRuleSetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/cdn_frontdoor_batch_rule_set#read DataAzurermCdnFrontdoorBatchRuleSet#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermCdnFrontdoorBatchRuleSetTimeouts), fullyQualifiedName: "azurerm.dataAzurermCdnFrontdoorBatchRuleSet.DataAzurermCdnFrontdoorBatchRuleSetTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermCdnFrontdoorBatchRuleSet.IDataAzurermCdnFrontdoorBatchRuleSetTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/data-sources/cdn_frontdoor_batch_rule_set#read DataAzurermCdnFrontdoorBatchRuleSet#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
