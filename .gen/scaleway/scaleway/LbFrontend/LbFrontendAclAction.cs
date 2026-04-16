using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.LbFrontend
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.lbFrontend.LbFrontendAclAction")]
    public class LbFrontendAclAction : scaleway.LbFrontend.ILbFrontendAclAction
    {
        /// <summary>The action type.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#type LbFrontend#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        private object? _redirect;

        /// <summary>redirect block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/lb_frontend#redirect LbFrontend#redirect}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirect", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"scaleway.lbFrontend.LbFrontendAclActionRedirect\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Redirect
        {
            get => _redirect;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case scaleway.LbFrontend.ILbFrontendAclActionRedirect[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(scaleway.LbFrontend.ILbFrontendAclActionRedirect).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _redirect = value;
            }
        }
    }
}
