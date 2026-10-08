using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOciProductCatalogProducts
{
    [JsiiInterface(nativeType: typeof(IDataOciOciProductCatalogProductsConfig), fullyQualifiedName: "oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsConfig")]
    public interface IDataOciOciProductCatalogProductsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#compartment_id DataOciOciProductCatalogProducts#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompartmentId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#description DataOciOciProductCatalogProducts#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#id DataOciOciProductCatalogProducts#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#lifecycle_state DataOciOciProductCatalogProducts#lifecycle_state}.</summary>
        [JsiiProperty(name: "lifecycleState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LifecycleState
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#limit DataOciOciProductCatalogProducts#limit}.</summary>
        [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Limit
        {
            get
            {
                return null;
            }
        }

        /// <summary>limits block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#limits DataOciOciProductCatalogProducts#limits}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsLimits" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "limits", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsLimits\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Limits
        {
            get
            {
                return null;
            }
        }

        /// <summary>meters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#meters DataOciOciProductCatalogProducts#meters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsMeters" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "meters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsMeters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Meters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#name DataOciOciProductCatalogProducts#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#page DataOciOciProductCatalogProducts#page}.</summary>
        [JsiiProperty(name: "page", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Page
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#service_name DataOciOciProductCatalogProducts#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#skus_contains DataOciOciProductCatalogProducts#skus_contains}.</summary>
        [JsiiProperty(name: "skusContains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SkusContains
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#time_ready_greater_than_or_equal_to DataOciOciProductCatalogProducts#time_ready_greater_than_or_equal_to}.</summary>
        [JsiiProperty(name: "timeReadyGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeReadyGreaterThanOrEqualTo
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataOciOciProductCatalogProductsConfig), fullyQualifiedName: "oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsConfig")]
        internal sealed class _Proxy : DeputyBase, oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#compartment_id DataOciOciProductCatalogProducts#compartment_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompartmentId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#description DataOciOciProductCatalogProducts#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#id DataOciOciProductCatalogProducts#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#lifecycle_state DataOciOciProductCatalogProducts#lifecycle_state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycleState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LifecycleState
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#limit DataOciOciProductCatalogProducts#limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "limit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Limit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>limits block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#limits DataOciOciProductCatalogProducts#limits}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsLimits" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limits", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsLimits\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Limits
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>meters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#meters DataOciOciProductCatalogProducts#meters}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciOciProductCatalogProducts.IDataOciOciProductCatalogProductsMeters" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "meters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciOciProductCatalogProducts.DataOciOciProductCatalogProductsMeters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Meters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#name DataOciOciProductCatalogProducts#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#page DataOciOciProductCatalogProducts#page}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "page", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Page
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#service_name DataOciOciProductCatalogProducts#service_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#skus_contains DataOciOciProductCatalogProducts#skus_contains}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "skusContains", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SkusContains
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/data-sources/oci_product_catalog_products#time_ready_greater_than_or_equal_to DataOciOciProductCatalogProducts#time_ready_greater_than_or_equal_to}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeReadyGreaterThanOrEqualTo", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeReadyGreaterThanOrEqualTo
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
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
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
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
