using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ApplicationOptionalClaims
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.applicationOptionalClaims.ApplicationOptionalClaimsIdTokenA")]
    public class ApplicationOptionalClaimsIdTokenA : azuread.ApplicationOptionalClaims.IApplicationOptionalClaimsIdTokenA
    {
        /// <summary>The name of the optional claim.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#name ApplicationOptionalClaimsA#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>List of additional properties of the claim.</summary>
        /// <remarks>
        /// If a property exists in this list, it modifies the behaviour of the optional claim
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#additional_properties ApplicationOptionalClaimsA#additional_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AdditionalProperties
        {
            get;
            set;
        }

        private object? _essential;

        /// <summary>Whether the claim specified by the client is necessary to ensure a smooth authorization experience.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#essential ApplicationOptionalClaimsA#essential}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "essential", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Essential
        {
            get => _essential;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _essential = value;
            }
        }

        /// <summary>The source of the claim.</summary>
        /// <remarks>
        /// If <c>source</c> is absent, the claim is a predefined optional claim. If <c>source</c> is <c>user</c>, the value of <c>name</c> is the extension property from the user object
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_optional_claims#source ApplicationOptionalClaimsA#source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Source
        {
            get;
            set;
        }
    }
}
