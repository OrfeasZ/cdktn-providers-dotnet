using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Plan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.plan.PlanTransformUsage")]
    public class PlanTransformUsage : stripe.Plan.IPlanTransformUsage
    {
        /// <summary>Divide usage by this number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#divide_by Plan#divide_by}
        /// </remarks>
        [JsiiProperty(name: "divideBy", typeJson: "{\"primitive\":\"number\"}")]
        public double DivideBy
        {
            get;
            set;
        }

        /// <summary>After division, either round the result `up` or `down`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/plan#round Plan#round}
        /// </remarks>
        [JsiiProperty(name: "round", typeJson: "{\"primitive\":\"string\"}")]
        public string Round
        {
            get;
            set;
        }
    }
}
