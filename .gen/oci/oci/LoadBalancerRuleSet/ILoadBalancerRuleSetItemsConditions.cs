using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoadBalancerRuleSet
{
    [JsiiInterface(nativeType: typeof(ILoadBalancerRuleSetItemsConditions), fullyQualifiedName: "oci.loadBalancerRuleSet.LoadBalancerRuleSetItemsConditions")]
    public interface ILoadBalancerRuleSetItemsConditions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_rule_set#attribute_name LoadBalancerRuleSet#attribute_name}.</summary>
        [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}")]
        string AttributeName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_rule_set#attribute_value LoadBalancerRuleSet#attribute_value}.</summary>
        [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
        string AttributeValue
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_rule_set#operator LoadBalancerRuleSet#operator}.</summary>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Operator
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoadBalancerRuleSetItemsConditions), fullyQualifiedName: "oci.loadBalancerRuleSet.LoadBalancerRuleSetItemsConditions")]
        internal sealed class _Proxy : DeputyBase, oci.LoadBalancerRuleSet.ILoadBalancerRuleSetItemsConditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_rule_set#attribute_name LoadBalancerRuleSet#attribute_name}.</summary>
            [JsiiProperty(name: "attributeName", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_rule_set#attribute_value LoadBalancerRuleSet#attribute_value}.</summary>
            [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributeValue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/load_balancer_rule_set#operator LoadBalancerRuleSet#operator}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Operator
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
