using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreAppCatalogSubscription
{
    [JsiiInterface(nativeType: typeof(ICoreAppCatalogSubscriptionConfig), fullyQualifiedName: "oci.coreAppCatalogSubscription.CoreAppCatalogSubscriptionConfig")]
    public interface ICoreAppCatalogSubscriptionConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#compartment_id CoreAppCatalogSubscription#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#listing_id CoreAppCatalogSubscription#listing_id}.</summary>
        [JsiiProperty(name: "listingId", typeJson: "{\"primitive\":\"string\"}")]
        string ListingId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#listing_resource_version CoreAppCatalogSubscription#listing_resource_version}.</summary>
        [JsiiProperty(name: "listingResourceVersion", typeJson: "{\"primitive\":\"string\"}")]
        string ListingResourceVersion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#oracle_terms_of_use_link CoreAppCatalogSubscription#oracle_terms_of_use_link}.</summary>
        [JsiiProperty(name: "oracleTermsOfUseLink", typeJson: "{\"primitive\":\"string\"}")]
        string OracleTermsOfUseLink
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#signature CoreAppCatalogSubscription#signature}.</summary>
        [JsiiProperty(name: "signature", typeJson: "{\"primitive\":\"string\"}")]
        string Signature
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#time_retrieved CoreAppCatalogSubscription#time_retrieved}.</summary>
        [JsiiProperty(name: "timeRetrieved", typeJson: "{\"primitive\":\"string\"}")]
        string TimeRetrieved
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#eula_link CoreAppCatalogSubscription#eula_link}.</summary>
        [JsiiProperty(name: "eulaLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EulaLink
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#id CoreAppCatalogSubscription#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#timeouts CoreAppCatalogSubscription#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.coreAppCatalogSubscription.CoreAppCatalogSubscriptionTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreAppCatalogSubscription.ICoreAppCatalogSubscriptionTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreAppCatalogSubscriptionConfig), fullyQualifiedName: "oci.coreAppCatalogSubscription.CoreAppCatalogSubscriptionConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CoreAppCatalogSubscription.ICoreAppCatalogSubscriptionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#compartment_id CoreAppCatalogSubscription#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#listing_id CoreAppCatalogSubscription#listing_id}.</summary>
            [JsiiProperty(name: "listingId", typeJson: "{\"primitive\":\"string\"}")]
            public string ListingId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#listing_resource_version CoreAppCatalogSubscription#listing_resource_version}.</summary>
            [JsiiProperty(name: "listingResourceVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string ListingResourceVersion
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#oracle_terms_of_use_link CoreAppCatalogSubscription#oracle_terms_of_use_link}.</summary>
            [JsiiProperty(name: "oracleTermsOfUseLink", typeJson: "{\"primitive\":\"string\"}")]
            public string OracleTermsOfUseLink
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#signature CoreAppCatalogSubscription#signature}.</summary>
            [JsiiProperty(name: "signature", typeJson: "{\"primitive\":\"string\"}")]
            public string Signature
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#time_retrieved CoreAppCatalogSubscription#time_retrieved}.</summary>
            [JsiiProperty(name: "timeRetrieved", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeRetrieved
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#eula_link CoreAppCatalogSubscription#eula_link}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eulaLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EulaLink
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#id CoreAppCatalogSubscription#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_app_catalog_subscription#timeouts CoreAppCatalogSubscription#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.coreAppCatalogSubscription.CoreAppCatalogSubscriptionTimeouts\"}", isOptional: true)]
            public oci.CoreAppCatalogSubscription.ICoreAppCatalogSubscriptionTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.CoreAppCatalogSubscription.ICoreAppCatalogSubscriptionTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
