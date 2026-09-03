using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SiteRecoveryProtectionContainerMapping
{
    [JsiiInterface(nativeType: typeof(ISiteRecoveryProtectionContainerMappingAutomaticUpdate), fullyQualifiedName: "azurerm.siteRecoveryProtectionContainerMapping.SiteRecoveryProtectionContainerMappingAutomaticUpdate")]
    public interface ISiteRecoveryProtectionContainerMappingAutomaticUpdate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/site_recovery_protection_container_mapping#automation_account_id SiteRecoveryProtectionContainerMapping#automation_account_id}.</summary>
        [JsiiProperty(name: "automationAccountId", typeJson: "{\"primitive\":\"string\"}")]
        string AutomationAccountId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/site_recovery_protection_container_mapping#authentication_type SiteRecoveryProtectionContainerMapping#authentication_type}.</summary>
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthenticationType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISiteRecoveryProtectionContainerMappingAutomaticUpdate), fullyQualifiedName: "azurerm.siteRecoveryProtectionContainerMapping.SiteRecoveryProtectionContainerMappingAutomaticUpdate")]
        internal sealed class _Proxy : DeputyBase, azurerm.SiteRecoveryProtectionContainerMapping.ISiteRecoveryProtectionContainerMappingAutomaticUpdate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/site_recovery_protection_container_mapping#automation_account_id SiteRecoveryProtectionContainerMapping#automation_account_id}.</summary>
            [JsiiProperty(name: "automationAccountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AutomationAccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/site_recovery_protection_container_mapping#authentication_type SiteRecoveryProtectionContainerMapping#authentication_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthenticationType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
