// *** WARNING: this file was generated by pulumi-language-nodejs. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export { CGProfileArgs } from "./cgprofile";
export type CGProfile = import("./cgprofile").CGProfile;
export const CGProfile: typeof import("./cgprofile").CGProfile = null as any;
utilities.lazyLoad(exports, ["CGProfile"], () => require("./cgprofile"));

export { ContainerGroupArgs } from "./containerGroup";
export type ContainerGroup = import("./containerGroup").ContainerGroup;
export const ContainerGroup: typeof import("./containerGroup").ContainerGroup = null as any;
utilities.lazyLoad(exports, ["ContainerGroup"], () => require("./containerGroup"));

export { ContainerGroupProfileArgs } from "./containerGroupProfile";
export type ContainerGroupProfile = import("./containerGroupProfile").ContainerGroupProfile;
export const ContainerGroupProfile: typeof import("./containerGroupProfile").ContainerGroupProfile = null as any;
utilities.lazyLoad(exports, ["ContainerGroupProfile"], () => require("./containerGroupProfile"));

export { GetCGProfileArgs, GetCGProfileResult, GetCGProfileOutputArgs } from "./getCGProfile";
export const getCGProfile: typeof import("./getCGProfile").getCGProfile = null as any;
export const getCGProfileOutput: typeof import("./getCGProfile").getCGProfileOutput = null as any;
utilities.lazyLoad(exports, ["getCGProfile","getCGProfileOutput"], () => require("./getCGProfile"));

export { GetContainerGroupArgs, GetContainerGroupResult, GetContainerGroupOutputArgs } from "./getContainerGroup";
export const getContainerGroup: typeof import("./getContainerGroup").getContainerGroup = null as any;
export const getContainerGroupOutput: typeof import("./getContainerGroup").getContainerGroupOutput = null as any;
utilities.lazyLoad(exports, ["getContainerGroup","getContainerGroupOutput"], () => require("./getContainerGroup"));

export { GetContainerGroupProfileArgs, GetContainerGroupProfileResult, GetContainerGroupProfileOutputArgs } from "./getContainerGroupProfile";
export const getContainerGroupProfile: typeof import("./getContainerGroupProfile").getContainerGroupProfile = null as any;
export const getContainerGroupProfileOutput: typeof import("./getContainerGroupProfile").getContainerGroupProfileOutput = null as any;
utilities.lazyLoad(exports, ["getContainerGroupProfile","getContainerGroupProfileOutput"], () => require("./getContainerGroupProfile"));

export { GetNGroupArgs, GetNGroupResult, GetNGroupOutputArgs } from "./getNGroup";
export const getNGroup: typeof import("./getNGroup").getNGroup = null as any;
export const getNGroupOutput: typeof import("./getNGroup").getNGroupOutput = null as any;
utilities.lazyLoad(exports, ["getNGroup","getNGroupOutput"], () => require("./getNGroup"));

export { NGroupArgs } from "./ngroup";
export type NGroup = import("./ngroup").NGroup;
export const NGroup: typeof import("./ngroup").NGroup = null as any;
utilities.lazyLoad(exports, ["NGroup"], () => require("./ngroup"));


// Export enums:
export * from "../types/enums/containerinstance";

// Export sub-modules:
import * as v20210301 from "./v20210301";
import * as v20210701 from "./v20210701";
import * as v20230201preview from "./v20230201preview";
import * as v20230501 from "./v20230501";
import * as v20240501preview from "./v20240501preview";
import * as v20240901preview from "./v20240901preview";
import * as v20241001preview from "./v20241001preview";
import * as v20241101preview from "./v20241101preview";

export {
    v20210301,
    v20210701,
    v20230201preview,
    v20230501,
    v20240501preview,
    v20240901preview,
    v20241001preview,
    v20241101preview,
};

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:containerinstance:CGProfile":
                return new CGProfile(name, <any>undefined, { urn })
            case "azure-native:containerinstance:ContainerGroup":
                return new ContainerGroup(name, <any>undefined, { urn })
            case "azure-native:containerinstance:ContainerGroupProfile":
                return new ContainerGroupProfile(name, <any>undefined, { urn })
            case "azure-native:containerinstance:NGroup":
                return new NGroup(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "containerinstance", _module)
