using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiClass(nativeType: typeof(digitalocean.App.AppSpecStaticSiteOutputReference), fullyQualifiedName: "digitalocean.app.AppSpecStaticSiteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppSpecStaticSiteOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppSpecStaticSiteOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecStaticSiteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppSpecStaticSiteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBitbucket", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecStaticSiteBitbucket\"}}]")]
        public virtual void PutBitbucket(digitalocean.App.IAppSpecStaticSiteBitbucket @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecStaticSiteBitbucket)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCors", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecStaticSiteCors\"}}]")]
        public virtual void PutCors(digitalocean.App.IAppSpecStaticSiteCors @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecStaticSiteCors)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnv", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecStaticSiteEnv\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutEnv(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.App.IAppSpecStaticSiteEnv[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecStaticSiteEnv).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecStaticSiteEnv).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGit", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGit\"}}]")]
        public virtual void PutGit(digitalocean.App.IAppSpecStaticSiteGit @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecStaticSiteGit)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithub", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGithub\"}}]")]
        public virtual void PutGithub(digitalocean.App.IAppSpecStaticSiteGithub @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecStaticSiteGithub)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGitlab", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGitlab\"}}]")]
        public virtual void PutGitlab(digitalocean.App.IAppSpecStaticSiteGitlab @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(digitalocean.App.IAppSpecStaticSiteGitlab)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRoutes", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecStaticSiteRoutes\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRoutes(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case digitalocean.App.IAppSpecStaticSiteRoutes[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecStaticSiteRoutes).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecStaticSiteRoutes).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBitbucket")]
        public virtual void ResetBitbucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuildCommand")]
        public virtual void ResetBuildCommand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCatchallDocument")]
        public virtual void ResetCatchallDocument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCors")]
        public virtual void ResetCors()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDockerfilePath")]
        public virtual void ResetDockerfilePath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnv")]
        public virtual void ResetEnv()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironmentSlug")]
        public virtual void ResetEnvironmentSlug()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetErrorDocument")]
        public virtual void ResetErrorDocument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGit")]
        public virtual void ResetGit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGithub")]
        public virtual void ResetGithub()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGitlab")]
        public virtual void ResetGitlab()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIndexDocument")]
        public virtual void ResetIndexDocument()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOutputDir")]
        public virtual void ResetOutputDir()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoutes")]
        public virtual void ResetRoutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceDir")]
        public virtual void ResetSourceDir()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "bitbucket", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteBitbucketOutputReference\"}")]
        public virtual digitalocean.App.AppSpecStaticSiteBitbucketOutputReference Bitbucket
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecStaticSiteBitbucketOutputReference>()!;
        }

        [JsiiProperty(name: "cors", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteCorsOutputReference\"}")]
        public virtual digitalocean.App.AppSpecStaticSiteCorsOutputReference Cors
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecStaticSiteCorsOutputReference>()!;
        }

        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteEnvList\"}")]
        public virtual digitalocean.App.AppSpecStaticSiteEnvList Env
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecStaticSiteEnvList>()!;
        }

        [JsiiProperty(name: "git", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGitOutputReference\"}")]
        public virtual digitalocean.App.AppSpecStaticSiteGitOutputReference Git
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecStaticSiteGitOutputReference>()!;
        }

        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGithubOutputReference\"}")]
        public virtual digitalocean.App.AppSpecStaticSiteGithubOutputReference Github
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecStaticSiteGithubOutputReference>()!;
        }

        [JsiiProperty(name: "gitlab", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGitlabOutputReference\"}")]
        public virtual digitalocean.App.AppSpecStaticSiteGitlabOutputReference Gitlab
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecStaticSiteGitlabOutputReference>()!;
        }

        [JsiiProperty(name: "routes", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteRoutesList\"}")]
        public virtual digitalocean.App.AppSpecStaticSiteRoutesList Routes
        {
            get => GetInstanceProperty<digitalocean.App.AppSpecStaticSiteRoutesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bitbucketInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteBitbucket\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecStaticSiteBitbucket? BitbucketInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecStaticSiteBitbucket?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "buildCommandInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuildCommandInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "catchallDocumentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CatchallDocumentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "corsInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteCors\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecStaticSiteCors? CorsInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecStaticSiteCors?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dockerfilePathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DockerfilePathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "envInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecStaticSiteEnv\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? EnvInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentSlugInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnvironmentSlugInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorDocumentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ErrorDocumentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGithub\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecStaticSiteGithub? GithubInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecStaticSiteGithub?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGit\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecStaticSiteGit? GitInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecStaticSiteGit?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gitlabInput", typeJson: "{\"fqn\":\"digitalocean.app.AppSpecStaticSiteGitlab\"}", isOptional: true)]
        public virtual digitalocean.App.IAppSpecStaticSiteGitlab? GitlabInput
        {
            get => GetInstanceProperty<digitalocean.App.IAppSpecStaticSiteGitlab?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "indexDocumentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IndexDocumentInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputDirInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OutputDirInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"digitalocean.app.AppSpecStaticSiteRoutes\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RoutesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDirInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceDirInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "buildCommand", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuildCommand
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "catchallDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CatchallDocument
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dockerfilePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DockerfilePath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "environmentSlug", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentSlug
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "errorDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorDocument
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "indexDocument", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IndexDocument
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "outputDir", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OutputDir
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceDir", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceDir
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"digitalocean.app.AppSpecStaticSite\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case digitalocean.App.IAppSpecStaticSite cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(digitalocean.App.IAppSpecStaticSite).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
