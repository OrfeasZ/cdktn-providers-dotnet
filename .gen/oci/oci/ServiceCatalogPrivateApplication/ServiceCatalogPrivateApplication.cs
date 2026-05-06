using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ServiceCatalogPrivateApplication
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/service_catalog_private_application oci_service_catalog_private_application}.</summary>
    [JsiiClass(nativeType: typeof(oci.ServiceCatalogPrivateApplication.ServiceCatalogPrivateApplication), fullyQualifiedName: "oci.serviceCatalogPrivateApplication.ServiceCatalogPrivateApplication", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"oci.serviceCatalogPrivateApplication.ServiceCatalogPrivateApplicationConfig\"}}]")]
    public class ServiceCatalogPrivateApplication : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/service_catalog_private_application oci_service_catalog_private_application} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ServiceCatalogPrivateApplication(Constructs.Construct scope, string id, oci.ServiceCatalogPrivateApplication.IServiceCatalogPrivateApplicationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, oci.ServiceCatalogPrivateApplication.IServiceCatalogPrivateApplicationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceCatalogPrivateApplication(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ServiceCatalogPrivateApplication(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a ServiceCatalogPrivateApplication resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ServiceCatalogPrivateApplication to import.</param>
        /// <param name="importFromId">The id of the existing ServiceCatalogPrivateApplication that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ServiceCatalogPrivateApplication to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ServiceCatalogPrivateApplication to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/service_catalog_private_application#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ServiceCatalogPrivateApplication that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ServiceCatalogPrivateApplication to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(oci.ServiceCatalogPrivateApplication.ServiceCatalogPrivateApplication), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putPackageDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.serviceCatalogPrivateApplication.ServiceCatalogPrivateApplicationPackageDetails\"}}]")]
        public virtual void PutPackageDetails(oci.ServiceCatalogPrivateApplication.IServiceCatalogPrivateApplicationPackageDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ServiceCatalogPrivateApplication.IServiceCatalogPrivateApplicationPackageDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.serviceCatalogPrivateApplication.ServiceCatalogPrivateApplicationTimeouts\"}}]")]
        public virtual void PutTimeouts(oci.ServiceCatalogPrivateApplication.IServiceCatalogPrivateApplicationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.ServiceCatalogPrivateApplication.IServiceCatalogPrivateApplicationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefinedTags")]
        public virtual void ResetDefinedTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFreeformTags")]
        public virtual void ResetFreeformTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogoFileBase64Encoded")]
        public virtual void ResetLogoFileBase64Encoded()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLongDescription")]
        public virtual void ResetLongDescription()
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
        = GetStaticProperty<string>(typeof(oci.ServiceCatalogPrivateApplication.ServiceCatalogPrivateApplication))!;

        [JsiiProperty(name: "logo", typeJson: "{\"fqn\":\"oci.serviceCatalogPrivateApplication.ServiceCatalogPrivateApplicationLogoList\"}")]
        public virtual oci.ServiceCatalogPrivateApplication.ServiceCatalogPrivateApplicationLogoList Logo
        {
            get => GetInstanceProperty<oci.ServiceCatalogPrivateApplication.ServiceCatalogPrivateApplicationLogoList>()!;
        }

        [JsiiProperty(name: "packageDetails", typeJson: "{\"fqn\":\"oci.serviceCatalogPrivateApplication.ServiceCatalogPrivateApplicationPackageDetailsOutputReference\"}")]
        public virtual oci.ServiceCatalogPrivateApplication.ServiceCatalogPrivateApplicationPackageDetailsOutputReference PackageDetails
        {
            get => GetInstanceProperty<oci.ServiceCatalogPrivateApplication.ServiceCatalogPrivateApplicationPackageDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "packageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PackageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"oci.serviceCatalogPrivateApplication.ServiceCatalogPrivateApplicationTimeoutsOutputReference\"}")]
        public virtual oci.ServiceCatalogPrivateApplication.ServiceCatalogPrivateApplicationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<oci.ServiceCatalogPrivateApplication.ServiceCatalogPrivateApplicationTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "compartmentIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompartmentIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definedTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? DefinedTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "displayNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisplayNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "freeformTagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? FreeformTagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logoFileBase64EncodedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogoFileBase64EncodedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "longDescriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LongDescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "packageDetailsInput", typeJson: "{\"fqn\":\"oci.serviceCatalogPrivateApplication.ServiceCatalogPrivateApplicationPackageDetails\"}", isOptional: true)]
        public virtual oci.ServiceCatalogPrivateApplication.IServiceCatalogPrivateApplicationPackageDetails? PackageDetailsInput
        {
            get => GetInstanceProperty<oci.ServiceCatalogPrivateApplication.IServiceCatalogPrivateApplicationPackageDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "shortDescriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ShortDescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.serviceCatalogPrivateApplication.ServiceCatalogPrivateApplicationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> DefinedTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> FreeformTags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logoFileBase64Encoded", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoFileBase64Encoded
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "longDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LongDescription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "shortDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ShortDescription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
