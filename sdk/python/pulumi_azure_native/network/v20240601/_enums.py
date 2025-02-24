# coding=utf-8
# *** WARNING: this file was generated by pulumi-language-python. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'ResolutionPolicy',
]


class ResolutionPolicy(str, Enum):
    """
    The resolution policy on the virtual network link. Only applicable for virtual network links to privatelink zones, and for A,AAAA,CNAME queries. When set to 'NxDomainRedirect', Azure DNS resolver falls back to public resolution if private dns query resolution results in non-existent domain response.
    """
    DEFAULT = "Default"
    NX_DOMAIN_REDIRECT = "NxDomainRedirect"
