using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.K8SCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.k8SCluster.K8SClusterOpenIdConnectConfig")]
    public class K8SClusterOpenIdConnectConfig : scaleway.K8SCluster.IK8SClusterOpenIdConnectConfig
    {
        /// <summary>A client id that all tokens must be issued for.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#client_id K8SCluster#client_id}
        /// </remarks>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientId
        {
            get;
            set;
        }

        /// <summary>URL of the provider which allows the API server to discover public signing keys.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#issuer_url K8SCluster#issuer_url}
        /// </remarks>
        [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string IssuerUrl
        {
            get;
            set;
        }

        /// <summary>JWT claim to use as the user's group.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#groups_claim K8SCluster#groups_claim}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groupsClaim", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? GroupsClaim
        {
            get;
            set;
        }

        /// <summary>Prefix prepended to group claims.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#groups_prefix K8SCluster#groups_prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groupsPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupsPrefix
        {
            get;
            set;
        }

        /// <summary>Multiple key=value pairs that describes a required claim in the ID Token.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#required_claim K8SCluster#required_claim}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requiredClaim", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RequiredClaim
        {
            get;
            set;
        }

        /// <summary>JWT claim to use as the user name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#username_claim K8SCluster#username_claim}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usernameClaim", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UsernameClaim
        {
            get;
            set;
        }

        /// <summary>Prefix prepended to username.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/k8s_cluster#username_prefix K8SCluster#username_prefix}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usernamePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UsernamePrefix
        {
            get;
            set;
        }
    }
}
