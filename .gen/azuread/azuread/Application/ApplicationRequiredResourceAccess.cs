using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.application.ApplicationRequiredResourceAccess")]
    public class ApplicationRequiredResourceAccess : azuread.Application.IApplicationRequiredResourceAccess
    {
        private object _resourceAccess;

        /// <summary>resource_access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#resource_access Application#resource_access}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="azuread.Application.IApplicationRequiredResourceAccessResourceAccess" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "resourceAccess", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azuread.application.ApplicationRequiredResourceAccessResourceAccess\"},\"kind\":\"array\"}}]}}")]
        public object ResourceAccess
        {
            get => _resourceAccess;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case azuread.Application.IApplicationRequiredResourceAccessResourceAccess[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationRequiredResourceAccessResourceAccess).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(azuread.Application.IApplicationRequiredResourceAccessResourceAccess).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _resourceAccess = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#resource_app_id Application#resource_app_id}.</summary>
        [JsiiProperty(name: "resourceAppId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceAppId
        {
            get;
            set;
        }
    }
}
