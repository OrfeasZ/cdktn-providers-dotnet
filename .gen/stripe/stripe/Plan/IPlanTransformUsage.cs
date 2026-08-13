using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Plan
{
    [JsiiInterface(nativeType: typeof(IPlanTransformUsage), fullyQualifiedName: "stripe.plan.PlanTransformUsage")]
    public interface IPlanTransformUsage
    {
        /// <summary>Divide usage by this number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#divide_by Plan#divide_by}
        /// </remarks>
        [JsiiProperty(name: "divideBy", typeJson: "{\"primitive\":\"number\"}")]
        double DivideBy
        {
            get;
        }

        /// <summary>After division, either round the result `up` or `down`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#round Plan#round}
        /// </remarks>
        [JsiiProperty(name: "round", typeJson: "{\"primitive\":\"string\"}")]
        string Round
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPlanTransformUsage), fullyQualifiedName: "stripe.plan.PlanTransformUsage")]
        internal sealed class _Proxy : DeputyBase, stripe.Plan.IPlanTransformUsage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Divide usage by this number.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#divide_by Plan#divide_by}
            /// </remarks>
            [JsiiProperty(name: "divideBy", typeJson: "{\"primitive\":\"number\"}")]
            public double DivideBy
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>After division, either round the result `up` or `down`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#round Plan#round}
            /// </remarks>
            [JsiiProperty(name: "round", typeJson: "{\"primitive\":\"string\"}")]
            public string Round
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
