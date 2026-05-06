using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.TenantmanagercontrolplaneSubscriptionMapping
{
    [JsiiInterface(nativeType: typeof(ITenantmanagercontrolplaneSubscriptionMappingTimeouts), fullyQualifiedName: "oci.tenantmanagercontrolplaneSubscriptionMapping.TenantmanagercontrolplaneSubscriptionMappingTimeouts")]
    public interface ITenantmanagercontrolplaneSubscriptionMappingTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/tenantmanagercontrolplane_subscription_mapping#create TenantmanagercontrolplaneSubscriptionMapping#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/tenantmanagercontrolplane_subscription_mapping#delete TenantmanagercontrolplaneSubscriptionMapping#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/tenantmanagercontrolplane_subscription_mapping#update TenantmanagercontrolplaneSubscriptionMapping#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITenantmanagercontrolplaneSubscriptionMappingTimeouts), fullyQualifiedName: "oci.tenantmanagercontrolplaneSubscriptionMapping.TenantmanagercontrolplaneSubscriptionMappingTimeouts")]
        internal sealed class _Proxy : DeputyBase, oci.TenantmanagercontrolplaneSubscriptionMapping.ITenantmanagercontrolplaneSubscriptionMappingTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/tenantmanagercontrolplane_subscription_mapping#create TenantmanagercontrolplaneSubscriptionMapping#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/tenantmanagercontrolplane_subscription_mapping#delete TenantmanagercontrolplaneSubscriptionMapping#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/tenantmanagercontrolplane_subscription_mapping#update TenantmanagercontrolplaneSubscriptionMapping#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
