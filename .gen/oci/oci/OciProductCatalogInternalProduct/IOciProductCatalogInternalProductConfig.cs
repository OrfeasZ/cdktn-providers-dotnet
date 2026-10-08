using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OciProductCatalogInternalProduct
{
    [JsiiInterface(nativeType: typeof(IOciProductCatalogInternalProductConfig), fullyQualifiedName: "oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductConfig")]
    public interface IOciProductCatalogInternalProductConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#compartment_id OciProductCatalogInternalProduct#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#description OciProductCatalogInternalProduct#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        string Description
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#name OciProductCatalogInternalProduct#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#service_name OciProductCatalogInternalProduct#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#backfill_eligibility OciProductCatalogInternalProduct#backfill_eligibility}.</summary>
        [JsiiProperty(name: "backfillEligibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackfillEligibility
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#id OciProductCatalogInternalProduct#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#is_excluded OciProductCatalogInternalProduct#is_excluded}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "isExcluded", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsExcluded
        {
            get
            {
                return null;
            }
        }

        /// <summary>limits block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#limits OciProductCatalogInternalProduct#limits}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductLimits" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "limits", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductLimits\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#meters OciProductCatalogInternalProduct#meters}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductMeters" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "meters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductMeters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Meters
        {
            get
            {
                return null;
            }
        }

        /// <summary>skus block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#skus OciProductCatalogInternalProduct#skus}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductSkus" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "skus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductSkus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Skus
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#timeouts OciProductCatalogInternalProduct#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOciProductCatalogInternalProductConfig), fullyQualifiedName: "oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductConfig")]
        internal sealed class _Proxy : DeputyBase, oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#compartment_id OciProductCatalogInternalProduct#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#description OciProductCatalogInternalProduct#description}.</summary>
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
            public string Description
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#name OciProductCatalogInternalProduct#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#service_name OciProductCatalogInternalProduct#service_name}.</summary>
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#backfill_eligibility OciProductCatalogInternalProduct#backfill_eligibility}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backfillEligibility", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackfillEligibility
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#id OciProductCatalogInternalProduct#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#is_excluded OciProductCatalogInternalProduct#is_excluded}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isExcluded", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsExcluded
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>limits block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#limits OciProductCatalogInternalProduct#limits}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductLimits" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limits", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductLimits\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Limits
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>meters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#meters OciProductCatalogInternalProduct#meters}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductMeters" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "meters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductMeters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Meters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>skus block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#skus OciProductCatalogInternalProduct#skus}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductSkus" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "skus", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductSkus\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Skus
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/oci_product_catalog_internal_product#timeouts OciProductCatalogInternalProduct#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.ociProductCatalogInternalProduct.OciProductCatalogInternalProductTimeouts\"}", isOptional: true)]
            public oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.OciProductCatalogInternalProduct.IOciProductCatalogInternalProductTimeouts?>();
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
