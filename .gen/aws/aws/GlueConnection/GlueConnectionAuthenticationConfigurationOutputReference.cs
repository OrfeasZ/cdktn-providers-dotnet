using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueConnection
{
    [JsiiClass(nativeType: typeof(aws.GlueConnection.GlueConnectionAuthenticationConfigurationOutputReference), fullyQualifiedName: "aws.glueConnection.GlueConnectionAuthenticationConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueConnectionAuthenticationConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueConnectionAuthenticationConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GlueConnectionAuthenticationConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueConnectionAuthenticationConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBasicAuthenticationCredentials", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials\"}}]")]
        public virtual void PutBasicAuthenticationCredentials(aws.GlueConnection.IGlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueConnection.IGlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOauth2Properties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2Properties\"}}]")]
        public virtual void PutOauth2Properties(aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2Properties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2Properties)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBasicAuthenticationCredentials")]
        public virtual void ResetBasicAuthenticationCredentials()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomAuthenticationCredentials")]
        public virtual void ResetCustomAuthenticationCredentials()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyArn")]
        public virtual void ResetKmsKeyArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOauth2Properties")]
        public virtual void ResetOauth2Properties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretArn")]
        public virtual void ResetSecretArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "basicAuthenticationCredentials", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationBasicAuthenticationCredentialsOutputReference\"}")]
        public virtual aws.GlueConnection.GlueConnectionAuthenticationConfigurationBasicAuthenticationCredentialsOutputReference BasicAuthenticationCredentials
        {
            get => GetInstanceProperty<aws.GlueConnection.GlueConnectionAuthenticationConfigurationBasicAuthenticationCredentialsOutputReference>()!;
        }

        [JsiiProperty(name: "oauth2Properties", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOutputReference\"}")]
        public virtual aws.GlueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOutputReference Oauth2Properties
        {
            get => GetInstanceProperty<aws.GlueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthenticationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "basicAuthenticationCredentialsInput", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials\"}", isOptional: true)]
        public virtual aws.GlueConnection.IGlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials? BasicAuthenticationCredentialsInput
        {
            get => GetInstanceProperty<aws.GlueConnection.IGlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customAuthenticationCredentialsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? CustomAuthenticationCredentialsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oauth2PropertiesInput", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2Properties\"}", isOptional: true)]
        public virtual aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2Properties? Oauth2PropertiesInput
        {
            get => GetInstanceProperty<aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2Properties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customAuthenticationCredentials", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> CustomAuthenticationCredentials
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfiguration\"}", isOptional: true)]
        public virtual aws.GlueConnection.IGlueConnectionAuthenticationConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.GlueConnection.IGlueConnectionAuthenticationConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
