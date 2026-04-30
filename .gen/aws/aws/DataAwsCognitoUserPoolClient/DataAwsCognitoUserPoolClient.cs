using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCognitoUserPoolClient
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/cognito_user_pool_client aws_cognito_user_pool_client}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClient), fullyQualifiedName: "aws.dataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClient", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClientConfig\"}}]")]
    public class DataAwsCognitoUserPoolClient : Io.Cdktn.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/cognito_user_pool_client aws_cognito_user_pool_client} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsCognitoUserPoolClient(Constructs.Construct scope, string id, aws.DataAwsCognitoUserPoolClient.IDataAwsCognitoUserPoolClientConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsCognitoUserPoolClient.IDataAwsCognitoUserPoolClientConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCognitoUserPoolClient(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCognitoUserPoolClient(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a DataAwsCognitoUserPoolClient resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsCognitoUserPoolClient to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsCognitoUserPoolClient that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsCognitoUserPoolClient to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsCognitoUserPoolClient to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/data-sources/cognito_user_pool_client#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsCognitoUserPoolClient that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsCognitoUserPoolClient to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(aws.DataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClient), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.DataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClient))!;

        [JsiiProperty(name: "accessTokenValidity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AccessTokenValidity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "allowedOauthFlows", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedOauthFlows
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "allowedOauthFlowsUserPoolClient", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowedOauthFlowsUserPoolClient
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "allowedOauthScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedOauthScopes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "analyticsConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClientAnalyticsConfigurationList\"}")]
        public virtual aws.DataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClientAnalyticsConfigurationList AnalyticsConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClientAnalyticsConfigurationList>()!;
        }

        [JsiiProperty(name: "callbackUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CallbackUrls
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "defaultRedirectUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultRedirectUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enablePropagateAdditionalUserContextData", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnablePropagateAdditionalUserContextData
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enableTokenRevocation", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EnableTokenRevocation
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "explicitAuthFlows", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExplicitAuthFlows
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "generateSecret", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable GenerateSecret
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idTokenValidity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IdTokenValidity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "logoutUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LogoutUrls
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preventUserExistenceErrors", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreventUserExistenceErrors
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "readAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ReadAttributes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "refreshTokenRotation", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClientRefreshTokenRotationList\"}")]
        public virtual aws.DataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClientRefreshTokenRotationList RefreshTokenRotation
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClientRefreshTokenRotationList>()!;
        }

        [JsiiProperty(name: "refreshTokenValidity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RefreshTokenValidity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "supportedIdentityProviders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedIdentityProviders
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tokenValidityUnits", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClientTokenValidityUnitsList\"}")]
        public virtual aws.DataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClientTokenValidityUnitsList TokenValidityUnits
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPoolClient.DataAwsCognitoUserPoolClientTokenValidityUnitsList>()!;
        }

        [JsiiProperty(name: "writeAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] WriteAttributes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RegionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPoolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserPoolIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPoolId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
