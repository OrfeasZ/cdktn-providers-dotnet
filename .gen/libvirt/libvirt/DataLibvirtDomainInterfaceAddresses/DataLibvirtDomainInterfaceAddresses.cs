using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.DataLibvirtDomainInterfaceAddresses
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/data-sources/domain_interface_addresses libvirt_domain_interface_addresses}.</summary>
    [JsiiClass(nativeType: typeof(libvirt.DataLibvirtDomainInterfaceAddresses.DataLibvirtDomainInterfaceAddresses), fullyQualifiedName: "libvirt.dataLibvirtDomainInterfaceAddresses.DataLibvirtDomainInterfaceAddresses", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"libvirt.dataLibvirtDomainInterfaceAddresses.DataLibvirtDomainInterfaceAddressesConfig\"}}]")]
    public class DataLibvirtDomainInterfaceAddresses : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/data-sources/domain_interface_addresses libvirt_domain_interface_addresses} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataLibvirtDomainInterfaceAddresses(Constructs.Construct scope, string id, libvirt.DataLibvirtDomainInterfaceAddresses.IDataLibvirtDomainInterfaceAddressesConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, libvirt.DataLibvirtDomainInterfaceAddresses.IDataLibvirtDomainInterfaceAddressesConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataLibvirtDomainInterfaceAddresses(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataLibvirtDomainInterfaceAddresses(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataLibvirtDomainInterfaceAddresses resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataLibvirtDomainInterfaceAddresses to import.</param>
        /// <param name="importFromId">The id of the existing DataLibvirtDomainInterfaceAddresses that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataLibvirtDomainInterfaceAddresses to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataLibvirtDomainInterfaceAddresses to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/data-sources/domain_interface_addresses#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataLibvirtDomainInterfaceAddresses that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataLibvirtDomainInterfaceAddresses to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(libvirt.DataLibvirtDomainInterfaceAddresses.DataLibvirtDomainInterfaceAddresses), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetSource")]
        public virtual void ResetSource()
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
        = GetStaticProperty<string>(typeof(libvirt.DataLibvirtDomainInterfaceAddresses.DataLibvirtDomainInterfaceAddresses))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "interfaces", typeJson: "{\"fqn\":\"libvirt.dataLibvirtDomainInterfaceAddresses.DataLibvirtDomainInterfaceAddressesInterfacesList\"}")]
        public virtual libvirt.DataLibvirtDomainInterfaceAddresses.DataLibvirtDomainInterfaceAddressesInterfacesList Interfaces
        {
            get => GetInstanceProperty<libvirt.DataLibvirtDomainInterfaceAddresses.DataLibvirtDomainInterfaceAddressesInterfacesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Source
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
