using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ManagementDashboardManagementDashboardsImport
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_dashboard_management_dashboards_import oci_management_dashboard_management_dashboards_import}.</summary>
    [JsiiClass(nativeType: typeof(oci.ManagementDashboardManagementDashboardsImport.ManagementDashboardManagementDashboardsImport), fullyQualifiedName: "oci.managementDashboardManagementDashboardsImport.ManagementDashboardManagementDashboardsImport", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"oci.managementDashboardManagementDashboardsImport.ManagementDashboardManagementDashboardsImportConfig\"}}]")]
    public class ManagementDashboardManagementDashboardsImport : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_dashboard_management_dashboards_import oci_management_dashboard_management_dashboards_import} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ManagementDashboardManagementDashboardsImport(Constructs.Construct scope, string id, oci.ManagementDashboardManagementDashboardsImport.IManagementDashboardManagementDashboardsImportConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.ManagementDashboardManagementDashboardsImport.IManagementDashboardManagementDashboardsImportConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagementDashboardManagementDashboardsImport(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ManagementDashboardManagementDashboardsImport(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ManagementDashboardManagementDashboardsImport resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ManagementDashboardManagementDashboardsImport to import.</param>
        /// <param name="importFromId">The id of the existing ManagementDashboardManagementDashboardsImport that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ManagementDashboardManagementDashboardsImport to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ManagementDashboardManagementDashboardsImport to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/management_dashboard_management_dashboards_import#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ManagementDashboardManagementDashboardsImport that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ManagementDashboardManagementDashboardsImport to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.ManagementDashboardManagementDashboardsImport.ManagementDashboardManagementDashboardsImport), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.managementDashboardManagementDashboardsImport.ManagementDashboardManagementDashboardsImportTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.ManagementDashboardManagementDashboardsImport.IManagementDashboardManagementDashboardsImportTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ManagementDashboardManagementDashboardsImport.IManagementDashboardManagementDashboardsImportTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImportDetails")]
        public virtual void ResetImportDetails()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImportDetailsFile")]
        public virtual void ResetImportDetailsFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOverrideDashboardCompartmentOcid")]
        public virtual void ResetOverrideDashboardCompartmentOcid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOverrideSameName")]
        public virtual void ResetOverrideSameName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOverrideSavedSearchCompartmentOcid")]
        public virtual void ResetOverrideSavedSearchCompartmentOcid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(oci.ManagementDashboardManagementDashboardsImport.ManagementDashboardManagementDashboardsImport))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.managementDashboardManagementDashboardsImport.ManagementDashboardManagementDashboardsImportTimeoutsOutputReference\"}")]
        public virtual oci.ManagementDashboardManagementDashboardsImport.ManagementDashboardManagementDashboardsImportTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.ManagementDashboardManagementDashboardsImport.ManagementDashboardManagementDashboardsImportTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "importDetailsFileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImportDetailsFileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "importDetailsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImportDetailsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "overrideDashboardCompartmentOcidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OverrideDashboardCompartmentOcidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "overrideSameNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OverrideSameNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "overrideSavedSearchCompartmentOcidInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OverrideSavedSearchCompartmentOcidInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.managementDashboardManagementDashboardsImport.ManagementDashboardManagementDashboardsImportTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "importDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImportDetails
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "importDetailsFile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImportDetailsFile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "overrideDashboardCompartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OverrideDashboardCompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "overrideSameName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OverrideSameName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "overrideSavedSearchCompartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OverrideSavedSearchCompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
