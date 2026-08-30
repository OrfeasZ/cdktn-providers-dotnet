using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace libvirt.Domain
{
    [JsiiInterface(nativeType: typeof(IDomainIommufd), fullyQualifiedName: "libvirt.domain.DomainIommufd")]
    public interface IDomainIommufd
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#enabled Domain#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}")]
        string Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fd_group Domain#fd_group}.</summary>
        [JsiiProperty(name: "fdGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FdGroup
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDomainIommufd), fullyQualifiedName: "libvirt.domain.DomainIommufd")]
        internal sealed class _Proxy : DeputyBase, libvirt.Domain.IDomainIommufd
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#enabled Domain#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"primitive\":\"string\"}")]
            public string Enabled
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/dmacvicar/libvirt/0.9.9/docs/resources/domain#fd_group Domain#fd_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fdGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FdGroup
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
