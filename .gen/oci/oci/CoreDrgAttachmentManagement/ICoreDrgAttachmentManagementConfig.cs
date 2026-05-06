using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CoreDrgAttachmentManagement
{
    [JsiiInterface(nativeType: typeof(ICoreDrgAttachmentManagementConfig), fullyQualifiedName: "oci.coreDrgAttachmentManagement.CoreDrgAttachmentManagementConfig")]
    public interface ICoreDrgAttachmentManagementConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#attachment_type CoreDrgAttachmentManagement#attachment_type}.</summary>
        [JsiiProperty(name: "attachmentType", typeJson: "{\"primitive\":\"string\"}")]
        string AttachmentType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#compartment_id CoreDrgAttachmentManagement#compartment_id}.</summary>
        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        string CompartmentId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#drg_id CoreDrgAttachmentManagement#drg_id}.</summary>
        [JsiiProperty(name: "drgId", typeJson: "{\"primitive\":\"string\"}")]
        string DrgId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#defined_tags CoreDrgAttachmentManagement#defined_tags}.</summary>
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#display_name CoreDrgAttachmentManagement#display_name}.</summary>
        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DisplayName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#drg_route_table_id CoreDrgAttachmentManagement#drg_route_table_id}.</summary>
        [JsiiProperty(name: "drgRouteTableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DrgRouteTableId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#export_drg_route_distribution_id CoreDrgAttachmentManagement#export_drg_route_distribution_id}.</summary>
        [JsiiProperty(name: "exportDrgRouteDistributionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExportDrgRouteDistributionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#freeform_tags CoreDrgAttachmentManagement#freeform_tags}.</summary>
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#id CoreDrgAttachmentManagement#id}.</summary>
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

        /// <summary>network_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#network_details CoreDrgAttachmentManagement#network_details}
        /// </remarks>
        [JsiiProperty(name: "networkDetails", typeJson: "{\"fqn\":\"oci.coreDrgAttachmentManagement.CoreDrgAttachmentManagementNetworkDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreDrgAttachmentManagement.ICoreDrgAttachmentManagementNetworkDetails? NetworkDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#network_id CoreDrgAttachmentManagement#network_id}.</summary>
        [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#remove_export_drg_route_distribution_trigger CoreDrgAttachmentManagement#remove_export_drg_route_distribution_trigger}.</summary>
        [JsiiProperty(name: "removeExportDrgRouteDistributionTrigger", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RemoveExportDrgRouteDistributionTrigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#route_table_id CoreDrgAttachmentManagement#route_table_id}.</summary>
        [JsiiProperty(name: "routeTableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RouteTableId
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#timeouts CoreDrgAttachmentManagement#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.coreDrgAttachmentManagement.CoreDrgAttachmentManagementTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.CoreDrgAttachmentManagement.ICoreDrgAttachmentManagementTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#vcn_id CoreDrgAttachmentManagement#vcn_id}.</summary>
        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VcnId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICoreDrgAttachmentManagementConfig), fullyQualifiedName: "oci.coreDrgAttachmentManagement.CoreDrgAttachmentManagementConfig")]
        internal sealed class _Proxy : DeputyBase, oci.CoreDrgAttachmentManagement.ICoreDrgAttachmentManagementConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#attachment_type CoreDrgAttachmentManagement#attachment_type}.</summary>
            [JsiiProperty(name: "attachmentType", typeJson: "{\"primitive\":\"string\"}")]
            public string AttachmentType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#compartment_id CoreDrgAttachmentManagement#compartment_id}.</summary>
            [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
            public string CompartmentId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#drg_id CoreDrgAttachmentManagement#drg_id}.</summary>
            [JsiiProperty(name: "drgId", typeJson: "{\"primitive\":\"string\"}")]
            public string DrgId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#defined_tags CoreDrgAttachmentManagement#defined_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? DefinedTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#display_name CoreDrgAttachmentManagement#display_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DisplayName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#drg_route_table_id CoreDrgAttachmentManagement#drg_route_table_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "drgRouteTableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DrgRouteTableId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#export_drg_route_distribution_id CoreDrgAttachmentManagement#export_drg_route_distribution_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exportDrgRouteDistributionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExportDrgRouteDistributionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#freeform_tags CoreDrgAttachmentManagement#freeform_tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? FreeformTags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#id CoreDrgAttachmentManagement#id}.</summary>
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

            /// <summary>network_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#network_details CoreDrgAttachmentManagement#network_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkDetails", typeJson: "{\"fqn\":\"oci.coreDrgAttachmentManagement.CoreDrgAttachmentManagementNetworkDetails\"}", isOptional: true)]
            public oci.CoreDrgAttachmentManagement.ICoreDrgAttachmentManagementNetworkDetails? NetworkDetails
            {
                get => GetInstanceProperty<oci.CoreDrgAttachmentManagement.ICoreDrgAttachmentManagementNetworkDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#network_id CoreDrgAttachmentManagement#network_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#remove_export_drg_route_distribution_trigger CoreDrgAttachmentManagement#remove_export_drg_route_distribution_trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "removeExportDrgRouteDistributionTrigger", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RemoveExportDrgRouteDistributionTrigger
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#route_table_id CoreDrgAttachmentManagement#route_table_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routeTableId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RouteTableId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#timeouts CoreDrgAttachmentManagement#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.coreDrgAttachmentManagement.CoreDrgAttachmentManagementTimeouts\"}", isOptional: true)]
            public oci.CoreDrgAttachmentManagement.ICoreDrgAttachmentManagementTimeouts? Timeouts
            {
                get => GetInstanceProperty<oci.CoreDrgAttachmentManagement.ICoreDrgAttachmentManagementTimeouts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/core_drg_attachment_management#vcn_id CoreDrgAttachmentManagement#vcn_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VcnId
            {
                get => GetInstanceProperty<string?>();
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
