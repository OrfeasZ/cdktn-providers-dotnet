using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueConnection
{
    [JsiiClass(nativeType: typeof(aws.GlueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOutputReference), fullyQualifiedName: "aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueConnectionAuthenticationConfigurationOauth2PropertiesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueConnectionAuthenticationConfigurationOauth2PropertiesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueConnectionAuthenticationConfigurationOauth2PropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueConnectionAuthenticationConfigurationOauth2PropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuthorizationCodeProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties\"}}]")]
        public virtual void PutAuthorizationCodeProperties(aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOauth2ClientApplication", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication\"}}]")]
        public virtual void PutOauth2ClientApplication(aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOauth2Credentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2Credentials\"}}]")]
        public virtual void PutOauth2Credentials(aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2Credentials @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2Credentials)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthorizationCodeProperties")]
        public virtual void ResetAuthorizationCodeProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauth2ClientApplication")]
        public virtual void ResetOauth2ClientApplication()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauth2Credentials")]
        public virtual void ResetOauth2Credentials()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauth2GrantType")]
        public virtual void ResetOauth2GrantType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTokenUrl")]
        public virtual void ResetTokenUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTokenUrlParametersMap")]
        public virtual void ResetTokenUrlParametersMap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "authorizationCodeProperties", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodePropertiesOutputReference\"}")]
        public virtual aws.GlueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodePropertiesOutputReference AuthorizationCodeProperties
        {
            get => GetInstanceProperty<aws.GlueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodePropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "oauth2ClientApplication", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplicationOutputReference\"}")]
        public virtual aws.GlueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplicationOutputReference Oauth2ClientApplication
        {
            get => GetInstanceProperty<aws.GlueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplicationOutputReference>()!;
        }

        [JsiiProperty(name: "oauth2Credentials", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2CredentialsOutputReference\"}")]
        public virtual aws.GlueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2CredentialsOutputReference Oauth2Credentials
        {
            get => GetInstanceProperty<aws.GlueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2CredentialsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationCodePropertiesInput", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties\"}", isOptional: true)]
        public virtual aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties? AuthorizationCodePropertiesInput
        {
            get => GetInstanceProperty<aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauth2ClientApplicationInput", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication\"}", isOptional: true)]
        public virtual aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication? Oauth2ClientApplicationInput
        {
            get => GetInstanceProperty<aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauth2CredentialsInput", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2Credentials\"}", isOptional: true)]
        public virtual aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2Credentials? Oauth2CredentialsInput
        {
            get => GetInstanceProperty<aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2Credentials?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauth2GrantTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? Oauth2GrantTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokenUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TokenUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokenUrlParametersMapInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TokenUrlParametersMapInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "oauth2GrantType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Oauth2GrantType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tokenUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TokenUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tokenUrlParametersMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TokenUrlParametersMap
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2Properties\"}", isOptional: true)]
        public virtual aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2Properties? InternalValue
        {
            get => GetInstanceProperty<aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2Properties?>();
            set => SetInstanceProperty(value);
        }
    }
}
