using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedhatOpenshiftCluster
{
    [JsiiInterface(nativeType: typeof(IRedhatOpenshiftClusterIdentity), fullyQualifiedName: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterIdentity")]
    public interface IRedhatOpenshiftClusterIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/redhat_openshift_cluster#identity_ids RedhatOpenshiftCluster#identity_ids}.</summary>
        [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] IdentityIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/redhat_openshift_cluster#type RedhatOpenshiftCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRedhatOpenshiftClusterIdentity), fullyQualifiedName: "azurerm.redhatOpenshiftCluster.RedhatOpenshiftClusterIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.RedhatOpenshiftCluster.IRedhatOpenshiftClusterIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/redhat_openshift_cluster#identity_ids RedhatOpenshiftCluster#identity_ids}.</summary>
            [JsiiProperty(name: "identityIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] IdentityIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.4.0/docs/resources/redhat_openshift_cluster#type RedhatOpenshiftCluster#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
