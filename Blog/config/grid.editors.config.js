[
    {
        "name": "Rich text editor",
        "alias": "rte",
        "view": "rte",
        "icon": "icon-article"
    },
    {
        "name": "Image",
        "alias": "media",
        "view": "media",
        "icon": "icon-picture"
    },
    {
        "name": "Macro",
        "alias": "macro",
        "view": "macro",
        "icon": "icon-settings-alt"
    },
    {
        "name": "Embed",
        "alias": "embed",
        "view": "embed",
        "icon": "icon-movie-alt"
    },
    {
        "name": "Headline",
        "alias": "headline",
        "view": "textstring",
        "icon": "icon-coin",
        "config": {
            "style": "font-size: 36px; line-height: 45px; font-weight: bold",
            "markup": "<h1>#value#</h1>"
        }
    },
    {
        "name": "Quote",
        "alias": "quote",
        "view": "textstring",
        "icon": "icon-quote",
        "config": {
            "style": "border-left: 3px solid #ccc; padding: 10px; color: #ccc; font-family: serif; font-style: italic; font-size: 18px",
            "markup": "<blockquote>#value#</blockquote>"
        }
    },
    {
        "name": "LastArticle",
        "alias": "lastArticle",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-newspaper-alt color-yellow",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [],
            "min": 1,
            "max": 1,
            "frontView": ""
        }
    },
    {
        "name": "Article",
        "alias": "article",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-newspaper color-yellow",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "editors": [
                {
                    "name": "ArticleContent",
                    "alias": "articleContent",
                    "propretyType": {},
                    "dataType": "93735b6c-c8fe-4c9d-961a-41534a0ccc2d"
                }
            ],
            "frontView": ""
        }
    },
    {
        "name": "AboutMeSection",
        "alias": "aboutMeSection",
        "view": "/App_Plugins/LeBlender/editors/leblendereditor/LeBlendereditor.html",
        "icon": "icon-user-female",
        "render": "/App_Plugins/LeBlender/editors/leblendereditor/views/Base.cshtml",
        "config": {
            "frontView": "",
            "editors": [
                {
                    "name": "AboutMeTitle",
                    "alias": "aboutMeTitle",
                    "propretyType": {},
                    "dataType": "0cc0eba1-9960-42c9-bf9b-60e150b429ae"
                },
                {
                    "name": "AboutMeContent",
                    "alias": "aboutMeContent",
                    "propretyType": {},
                    "dataType": "ca90c950-0aff-4e72-b976-a30b1ac57dad"
                },
                {
                    "name": "AboutMePick",
                    "alias": "aboutMePick",
                    "propretyType": {},
                    "dataType": "135d60e0-64d9-49ed-ab08-893c9ba44ae5"
                }
            ]
        }
    }
]